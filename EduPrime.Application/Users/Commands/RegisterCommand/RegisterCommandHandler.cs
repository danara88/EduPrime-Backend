using AutoMapper;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Commands.RegisterCommand
{
    /// <summary>
    /// Register command handler
    /// </summary>
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<UserDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPasswordService _passwordService;
        private readonly IEmailSender _emailSender;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RegisterCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IPasswordService passwordService,
            IEmailSender emailSender,
            IHttpContextAccessor httpContextAccessor,
            IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _passwordService = passwordService;
            _emailSender = emailSender;
            _httpContextAccessor = httpContextAccessor;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<ErrorOr<UserDTO>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.UserRepository.UserEmailExistsAsync(request.registerUserDTO.Email))
            {
                return UserErrors.UserEmailAlreadyRegistered(request.registerUserDTO.Email);
            }

            // TODO: Change method name IsValidPassword to IsValidPasswordFormat
            if (!_passwordService.IsValidPassword(request.registerUserDTO.Password))
            {
                return UserErrors.InvalidPasswordFormat;
            }

            var user = _mapper.Map<User>(request.registerUserDTO);

            // Hashing the password
            user.Password = _passwordService.HashPassword(user.Password);

            // Assign lowest permissions
            user.RoleId = (await _unitOfWork.RoleRepository.GetGuestRole()).Id;

            // Set email confirmation to false & generate verification token & assign expiration time for verification
            user.EmailConfirmed = false;
            user.VerificationToken = GenerateVerificationToken();
            user.VerificationTokenExpirationTime = DateTime.UtcNow.AddMinutes(10);

            await _unitOfWork.UserRepository.AddAsync(user);

            try
            {
                await _unitOfWork.SaveChangesAsync();

                // TODO: Implement event domain pattern here
                await SendVerificationEmail(user);

                var userDTO = _mapper.Map<UserDTO>(user);

                return userDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }

        /// <summary>
        /// Send verification email
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task SendVerificationEmail(User user)
        {
            // Example: https://localhost:44392/api/users/v1/confirm-email?code=exampleCode
            var callbackUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host.Value}"
                               + $"/api/users/v2/confirm-email?code={user.VerificationToken}";

            var pathToFile = _hostEnvironment.WebRootPath + Path.DirectorySeparatorChar.ToString()
                + "Templates" + Path.DirectorySeparatorChar.ToString() + "EmailTemplates"
                + Path.DirectorySeparatorChar.ToString() + "Confirm_Account_Registration.html";

            var htmlBody = "";
            using (StreamReader streamReader = System.IO.File.OpenText(pathToFile))
            {
                htmlBody = streamReader.ReadToEnd();
            }

            string callbackUrlItem = $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}' style=\"font-size: 1rem;padding: 0.5rem;background-color: #18A3C5;color: white;text-decoration: none;border-radius: 0.4rem;margin: 1rem 0rem;display: inline-block;font-weight: bold;\">Confirm Email Address</a>";

            string messageBody = string.Format(htmlBody, user.Email, callbackUrlItem);

            try
            {
                await _emailSender.SendEmailAsync(user.Email, "EduPrime Inc. Confirm your email.", messageBody);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Generates a random verification token
        /// </summary>
        /// <returns></returns>
        private string GenerateVerificationToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
    }
}
