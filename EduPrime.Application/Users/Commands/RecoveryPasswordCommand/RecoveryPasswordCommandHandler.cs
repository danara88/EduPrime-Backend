using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Helpers.Security;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Recovery password command handler
    /// </summary>
    public class RecoveryPasswordCommandHandler : IRequestHandler<RecoveryPasswordCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISecurityHelper _securityHelper;
        private readonly IEmailSender _emailSender;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IDataProtector _dataProtector;

        public RecoveryPasswordCommandHandler(
            IUnitOfWork unitOfWork, 
            ISecurityHelper securityHelper,
            IEmailSender emailSender, 
            IHttpContextAccessor httpContextAccessor,
            IDataProtectionProvider dataProtectionProvider,
            IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _securityHelper = securityHelper;
            _emailSender = emailSender;
            _httpContextAccessor = httpContextAccessor;
            _hostEnvironment = hostEnvironment;
            _dataProtector = dataProtectionProvider.CreateProtector("RecoveryPasswordEmail");
        }

        public async Task<string> Handle(RecoveryPasswordCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetUserByEmail(request.recoveryPasswordDTO.Email);
            if (userDB is null)
            {
                throw new BadRequestException("Something went wrong while sending recovery password email.");
            }

            if (!userDB.EmailConfirmed)
            {
                throw new BadRequestException("The email needs to be confirmed.");
            }

            try
            {
                await SendRecoveryPasswordEmail(userDB);
                return "Recovery password email sent";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while sending recovery password email.");
            }
        }

        /// <summary>
        /// Send recovery password email
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task SendRecoveryPasswordEmail(User user)
        {
            var expirationTimeEncrypted = _securityHelper.EncryptString(DateTime.Now.AddHours(1).ToString("yyyy-MM-dd/HH:mm:ss"));
            var callbackUrl = $@"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host.Value}/recover-your-password" +
                $"?Email={_dataProtector.Protect(user.Email)}" +
                $"&ExpirationTime={expirationTimeEncrypted}";

            var pathToFile = _hostEnvironment.WebRootPath + Path.DirectorySeparatorChar.ToString()
                + "Templates" + Path.DirectorySeparatorChar.ToString() + "EmailTemplates"
                + Path.DirectorySeparatorChar.ToString() + "Recovery_Password_Template.html";

            var htmlBody = "";
            using (StreamReader streamReader = System.IO.File.OpenText(pathToFile))
            {
                htmlBody = streamReader.ReadToEnd();
            }

            string callbackUrlItem = $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}' style=\"font-size: 1rem;padding: 0.5rem;background-color: #18A3C5;color: white;text-decoration: none;border-radius: 0.4rem;margin: 1rem 0rem;display: inline-block;font-weight: bold;\">Update Password</a>";

            string messageBody = string.Format(htmlBody, user.Name, callbackUrlItem);

            try
            {
                await _emailSender.SendEmailAsync(user.Email, "EduPrime Inc. Recover password.", messageBody);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
