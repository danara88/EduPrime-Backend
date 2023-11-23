using AutoMapper;
using EduPrime.Api.Controllers;
using EduPrime.Api.Response;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.AzureServices;
using EduPrime.Infrastructure.Services;
using EduPrime.Tests.Mocks;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EduPrime.Tests.Controllers
{
    public class EmployeesControllerTests
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepositoryService _employeeRepositoryService;
        private readonly IMapper _mapper;
        private readonly IBlobStorageService _blobStorageService;
        private readonly IFileHelper _fileHelper;
        private readonly IOptions<AzureSettings> _azureSettings;

        public EmployeesControllerTests()
        {
            _unitOfWork = A.Fake<IUnitOfWork>();
            _employeeRepositoryService = A.Fake<IEmployeeRepositoryService>();
            _mapper = A.Fake<IMapper>();
            _blobStorageService = A.Fake<IBlobStorageService>();
            _azureSettings = A.Fake<IOptions<AzureSettings>>();
            _fileHelper = A.Fake<IFileHelper>();
        }

        #region GetEmployees
        [Fact]
        public async void EmployeesController_GetEmployees_ReturnOK()
        {
            // Arrange
            var controller = new EmployeesController(_unitOfWork, _mapper, _employeeRepositoryService, _blobStorageService, _azureSettings, _fileHelper);
            A.CallTo(() => _unitOfWork.EmployeeRepository.GetAllAsync()).Returns(EmployeeMocks.employeesMock);
            A.CallTo(() => _mapper.Map<List<EmployeeDTO>>(EmployeeMocks.employeesMock)).Returns(EmployeeMocks.employeesDtoMock);
            // Act
            var result = await controller.GetEmployees();
            // Assert
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<List<EmployeeDTO>>>().Subject;
            apiResponse.Data.Should().HaveCount(2);
            apiResponse.Data.Should().BeEquivalentTo(EmployeeMocks.employeesDtoMock);
        }
        #endregion

        #region GetEmployeeById
        [Fact]
        public async void EmployeesController_GetEmployeeById_ReturnOK()
        {
            // Arrange
            var controller = new EmployeesController(_unitOfWork, _mapper, _employeeRepositoryService, _blobStorageService, _azureSettings, _fileHelper);
            A.CallTo(() => _unitOfWork.EmployeeRepository.GetByIdAsync(1)).Returns(EmployeeMocks.employeeMock);
            A.CallTo(() => _mapper.Map<EmployeeDTO>(EmployeeMocks.employeeMock)).Returns(EmployeeMocks.employeeDtoMock);
            // Act
            var result = await controller.GetEmployeeById(1);
            // Assert
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<EmployeeDTO>>().Subject;
            apiResponse.Data.Should().NotBeNull();
            apiResponse.Data.Should().BeEquivalentTo(EmployeeMocks.employeeDtoMock);
        }

        [Fact]
        public async void EmployeesController_GetEmployeeById_ReturnNotFound()
        {
            // Arrange
            var controller = new EmployeesController(_unitOfWork, _mapper, _employeeRepositoryService, _blobStorageService, _azureSettings, _fileHelper);
            Employee employeeNull = null!;
            A.CallTo(() => _unitOfWork.EmployeeRepository.GetByIdAsync(999)).Returns(employeeNull);
            // Act
            var result = await controller.GetEmployeeById(999);
            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }
        #endregion

        [Fact]
        public async void EmployeesController_CreateEmployee_ReturnOK()
        {
            // Arrange
            var controller = new EmployeesController(_unitOfWork, _mapper, _employeeRepositoryService, _blobStorageService, _azureSettings, _fileHelper);
            var createEmployeeDTO = new CreateEmployeeDTO
            {
                Name = "Test",
                Surname = "Test",
                Email = "test@test.com",
                PhoneNumber = "844767678",
                Areas = new List<int> { 1, 2 },
                Professor = null
            };
            var mockEmployee = new Employee
            {
                Id = 0,
                Name = "Test",
                Surname = "Test",
                Email = "test@test.com",
                PhoneNumber = "844767678",
                Areas = new List<Area> { },
                Professor = null!
            };
            A.CallTo(() => _mapper.Map<Employee>(createEmployeeDTO)).Returns(mockEmployee);
            // Act
            var result = await controller.CreateEmployee(createEmployeeDTO);
            // Assert
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<EmployeeDTO>>().Subject;
            apiResponse.Status.Should().Be(StatusCodes.Status201Created);
            A.CallTo(() => _unitOfWork.EmployeeRepository.AddAsync(mockEmployee)).MustHaveHappened();
            A.CallTo(() => _unitOfWork.SaveChangesAsync()).MustHaveHappened();
        }

        [Fact]
        public async void EmployeesController_CreateEmployee_NotProfessorAreaAssigned_ThrowsInternalServerException()
        {
            // Arrange
            var controller = new EmployeesController(_unitOfWork, _mapper, _employeeRepositoryService, _blobStorageService, _azureSettings, _fileHelper);
            var createEmployeeDTO = new CreateEmployeeDTO
            {
                Name = "Test",
                Surname = "Test",
                Email = "test@test.com",
                PhoneNumber = "844767678",
                Areas = new List<int> { },
                Professor = new CreateProfessorDTO
                {
                    EmployeeId = 1,
                    Satisfaction = 100,
                    YearsOnDuty = 100
                }
            };
            var mockEmployee = new Employee
            {
                Id = 0,
                Name = "Test",
                Surname = "Test",
                Email = "test@test.com",
                PhoneNumber = "844767678",
                Areas = new List<Area> { },
                Professor = new Professor
                {
                    Id = 0,
                    EmployeeId = 1,
                    Satisfaction = 100,
                    YearsOnDuty = 100
                }
            };
            A.CallTo(() => _mapper.Map<Employee>(createEmployeeDTO)).Returns(mockEmployee);
            // Act & Assert
            await Assert.ThrowsAsync<InternalServerException>(() => controller.CreateEmployee(createEmployeeDTO));
        }
    }
}
