using AutoMapper;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc;
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

        public UsersController(IUnitOfWork unitOfWork, IPasswordHasher passwordHasher, IMapper mapper, IJwtFactory jwtFactory)
        {
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _jwtFactory = jwtFactory;
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
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

            if (await _unitOfWork.UserRepository.UserEmailExistsAsync(registerUserDTO.Email))
            {
                throw new BadRequestException($"The email {registerUserDTO.Email} is already registered.");
            }

            if (!IsValidPasword(registerUserDTO.Password))
            {
                throw new BadRequestException("Invalid password.");
            }

            var user = _mapper.Map<User>(registerUserDTO);

            // Hashing the password and assign lowest permissions
            user.Password = _passwordHasher.Hash(user.Password);
            user.RoleId = (await _unitOfWork.RoleRepository.GetGuestRole()).Id;

            await _unitOfWork.UserRepository.AddAsync(user);

            try
            {
                await _unitOfWork.SaveChangesAsync();
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
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

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

            AuthTokenDTO authTokenDTO = new()
            {
                AccessToken = _jwtFactory.GenerateJwtToken(user)
            };

            var response = new ApiResponse<AuthTokenDTO>(authTokenDTO);
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
    }
}
