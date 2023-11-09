using AutoMapper;
using EduPrime.API.Attributes;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace EduPrime.API.Controllers
{
    [Route("api/users/v1")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IJwtFactory _jwtFactory;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UsersController(
            IUnitOfWork unitOfWork,
            IPasswordHasher passwordHasher,
            IMapper mapper,
            IJwtFactory jwtFactory,
            IEmailSender emailSender,
            IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _jwtFactory = jwtFactory;
            _emailSender = emailSender;
            _hostEnvironment = hostEnvironment;
        }

        /// <summary>
        /// End point to register a user
        /// </summary>
        /// <param name="registerUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register(RegisterUserDTO registerUserDTO)
        {
            if (await _unitOfWork.UserRepository.UserEmailExistsAsync(registerUserDTO.Email))
            {
                throw new BadRequestException($"The email {registerUserDTO.Email} is already registered.");
            }

            if (!IsValidPasword(registerUserDTO.Password))
            {
                throw new BadRequestException("Invalid password.");
            }

            var user = _mapper.Map<User>(registerUserDTO);

            // Hashing the password
            user.Password = _passwordHasher.Hash(user.Password);

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
                await SendVerificationEmail(user);
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var userDTO = _mapper.Map<UserDTO>(user);
            var response = new ApiResponse<UserDTO>(userDTO);
            
            return Ok(response);
        }

        /// <summary>
        /// End point to login a user
        /// </summary>
        /// <param name="logInUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> LogIn(LogInUserDTO logInUserDTO)
        {
            var emailExists = await _unitOfWork.UserRepository.UserEmailExistsAsync(logInUserDTO.Email);
            if (!emailExists)
            {
                throw new BadRequestException("The email or password are invalid.");
            }

            var user = await _unitOfWork.UserRepository.GetUserByEmail(logInUserDTO.Email);

            var validPassword = _passwordHasher.Check(user.Password, logInUserDTO.Password);
            if (!validPassword)
            {
                throw new BadRequestException("The email or password are invalid.");
            }

            if (!user.EmailConfirmed)
            {
                throw new BadRequestException("The email needs to be confirmed.");
            }

            user.LastLogin = DateTime.UtcNow;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while log in user.");
            }

            AuthTokenDTO authTokenDTO = new()
            {
                AccessToken = _jwtFactory.GenerateJwtToken(user)
            };

            var response = new ApiResponse<AuthTokenDTO>(authTokenDTO);
            return Ok(response);
        }

        /// <summary>
        /// End point to confirm user's email
        /// </summary>
        /// <param name="confirmEmailDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpGet("confirm-email")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailDTO confirmEmailDTO)
        {
            var userDB = await _unitOfWork.UserRepository.GetByVerificationTokenAsync(confirmEmailDTO.Code);
            if (userDB is null)
            {
                throw new BadRequestException($"The verification token is invalid.");
            }

            if (userDB.EmailConfirmed)
            {
                throw new BadRequestException($"The email is already confirmed.");
            }

            if (DateTime.UtcNow > userDB.VerificationTokenExpirationTime)
            {
                throw new BadRequestException($"The verification token has expired.");
            }

            userDB.EmailConfirmed = true;
            userDB.VerifiedAt = DateTime.UtcNow;

            try
            {
                await _unitOfWork.SaveChangesAsync();
                var response = new ApiResponse<object>(null);

                return Ok(response);
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while verifying the email.");
            }
            
        }

        /// <summary>
        /// End point to get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-users")]
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            var usersDTO = _mapper.Map<List<UserDTO>>(users);

            return Ok(new ApiResponse<List<UserDTO>>(usersDTO));
        }

        /// <summary>
        /// End point to get a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdWithAssignedRoleAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            var userDTO = _mapper.Map<UserDTO>(user);
            var response = new ApiResponse<UserDTO>(userDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to update a user
        /// </summary>
        /// <param name="updateUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPut("update-user")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDTO updateUserDTO)
        {
            var userDB = await _unitOfWork.UserRepository.GetByIdAsync(updateUserDTO.Id);
            if (userDB is null)
            {
                throw new BadRequestException($"The user with id {updateUserDTO.Id} does not exist.");
            }

            userDB = _mapper.Map(updateUserDTO, userDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }

        /// <summary>
        /// End point to delete a user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpDelete("delete-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var userDB = await _unitOfWork.UserRepository.GetByIdAsync(id);
            if (userDB is null)
            {
                throw new BadRequestException($"The user with id {id} does not exist.");
            }

            try
            {
                await _unitOfWork.UserRepository.Delete(userDB.Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }

        /// <summary>
        /// Validates the password format
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool IsValidPasword(string password)
        {
            bool validPassword = true;

            // Password must has at least 7 characters
            if (password.Length < 7) validPassword = false;

            // Password must contains at leat one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]")) validPassword = false;

            // Password must contains both letters and numbers
            if (!Regex.IsMatch(password, "[a-zA-Z]") || !Regex.IsMatch(password, "[0-9]")) validPassword = false;

            return validPassword;
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
            var callbackUrl = $@"{Request.Scheme}://{Request.Host}{Url.Action("ConfirmEmail", controller: "Users",
                new { code = user.VerificationToken })}";

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
