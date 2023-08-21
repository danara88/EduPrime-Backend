using AutoMapper;
using EduPrime.API.Controllers;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.Tests.Controllers
{
    public class AreasControllerTests
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
       
        public AreasControllerTests()
        {
            _unitOfWork = A.Fake<IUnitOfWork>();
            _mapper = A.Fake<IMapper>();
        }

        #region GetAreas
        [Fact]
        public async void AreasController_GetAreas_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var areas = new List<Area>
            {
                new Area {Id = 1, Name = "Test", Description = "Test description", CreatedOn = DateTime.Now},
                new Area {Id = 2, Name = "Test",  Description = "Test", CreatedOn = DateTime.Now}
            };
            var areasDTO = new List<AreaDTO>
            {
                new AreaDTO {Id = 1, Name = "Test", Description = "Test description"},
                new AreaDTO {Id = 2, Name = "Test", Description = "Test description"}
            };
            A.CallTo(() => _unitOfWork.AreaRepository.GetAllAsync()).Returns(areas);
            A.CallTo(() => _mapper.Map<List<AreaDTO>>(areas)).Returns(areasDTO);
            // Act
            var result = await controller.GetAreas();
            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResult.Value.Should().BeOfType<ApiResponse<List<AreaDTO>>>().Subject;
            apiResponse.Data.Should().NotBeNull();
            apiResponse.Data.Should().HaveCount(2);
            apiResponse.Data.Should().BeEquivalentTo(areasDTO);
        }
        #endregion

        #region GetAreaById
        [Fact]
        public async void AreasController_GetAreaById_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var area = new Area
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                CreatedOn = DateTime.Now
            };
            var areaDTO = new AreaDTO
            {
                Id = 1,
                Name = "Test",
                Description = "Test"
            };
            A.CallTo(() => _mapper.Map<AreaDTO>(area)).Returns(areaDTO);
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(area.Id)).Returns(area);
            // Act
            var result = await controller.GetAreaById(area.Id);
            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResult.Value.Should().BeOfType<ApiResponse<AreaDTO>>().Subject;
            apiResponse.Data.Should().NotBeNull();
            apiResponse.Data.Should().BeEquivalentTo(areaDTO);
        }

        [Fact]
        public async void AreasController_GetAreaById_ReturnNotFound()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var id = 999;
            Area area = null!;
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(id)).Returns(area);
            // Act
            var result = await controller.GetAreaById(id);
            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }
        #endregion

        #region CreateArea
        [Fact]
        public async void AreasController_CreateArea_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var createAreaDTO = new CreateAreaDTO
            {
                Name = "Test",
                Description = "Test"
            };
            var area = new Area
            {
                Id = 0,
                Name = "Test",
                Description = "Test",
                CreatedOn = DateTime.Now
            };
            A.CallTo(() => _mapper.Map<Area>(createAreaDTO)).Returns(area);
            // Act
            var result = await controller.CreateArea(createAreaDTO);
            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResult.Value.Should().BeOfType<ApiResponse<object>>().Subject;
            apiResponse.Status.Should().Be(StatusCodes.Status201Created);
            A.CallTo(() => _unitOfWork.AreaRepository.AddAsync(area)).MustHaveHappened();
            A.CallTo(() => _unitOfWork.SaveChangesAsync()).MustHaveHappened();
        }

        [Fact]
        public async void AreasController_CreateArea_ModelStateInvalid_ThrowsBadRequestException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var createAreaDTO = new CreateAreaDTO
            {
                Name = "Test",
                Description = "Test"
            };
            controller.ModelState.AddModelError("Test Error", "Test Error");
            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() => controller.CreateArea(createAreaDTO));
        }

        [Fact]
        public async void AreasController_CreateArea_AreaAlreadyExists_ThrowsBadRequestException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var createAreaDTO = new CreateAreaDTO
            {
                Name = "Test",
                Description = "Test"
            };
            A.CallTo(() => _unitOfWork.AreaRepository.ExistsAnyArea(createAreaDTO.Name)).Returns(true);
            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() => controller.CreateArea(createAreaDTO));
        }

        [Fact]
        public async void AreasController_CreateArea_ThrowsInternalServerException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var createAreaDTO = new CreateAreaDTO
            {
                Name = "Test",
                Description = "Test"
            };
            var area = new Area
            {
                Id = 0,
                Name = "Test",
                Description = "Test",
                CreatedOn = DateTime.Now
            };
            A.CallTo(() => _mapper.Map<Area>(createAreaDTO)).Returns(area);
            A.CallTo(() => _unitOfWork.AreaRepository.AddAsync(area)).Throws(new Exception("Test exception"));
            // Act & Assert
            await Assert.ThrowsAsync<InternalServerException>(() => controller.CreateArea(createAreaDTO));
        }
        #endregion

        #region UpdateArea
        [Fact]
        public async void AreasController_UpdateArea_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var updateAreaDTO = new UpdateAreaDTO
            {
                Id = 1,
                Name = "Test Update",
                Description = "Test"
            };
            var area = new Area
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                CreatedOn = DateTime.Now
            };
            var updatedArea = new Area
            {
                Id = 1,
                Name = "Test Update",
                Description = "Test",
                CreatedOn = DateTime.Now
            };
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(updateAreaDTO.Id)).Returns(area);
            A.CallTo(() => _mapper.Map(updateAreaDTO, area)).Returns(updatedArea);
            // Act
            var result = await controller.UpdateArea(updateAreaDTO);
            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<object>>().Subject;
            apiResponse.Status.Should().Be(StatusCodes.Status200OK);
            A.CallTo(() => _unitOfWork.SaveChangesAsync()).MustHaveHappened();
        }

        [Fact]
        public async void AreasController_UpdateArea_ModelStateInvalid_ThrowsBadRequestException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var updateAreaDTO = new UpdateAreaDTO
            {
                Id = 1,
                Name = "Test Update",
                Description = "Test"
            };
            controller.ModelState.AddModelError("Test Error", "Test Error");
            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() => controller.UpdateArea(updateAreaDTO));
        }

        [Fact]
        public async void AreasController_UpdateArea_AreaDoesNotExist_ThrowsBadRequestException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var updateAreaDTO = new UpdateAreaDTO
            {
                Id = 1,
                Name = "Test Update",
                Description = "Test"
            };
            Area area = null!;
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(updateAreaDTO.Id)).Returns(area);
            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() => controller.UpdateArea(updateAreaDTO));
        }

        [Fact]
        public async void AreasController_UpdateArea_ThrowsInternalServerException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var updateAreaDTO = new UpdateAreaDTO
            {
                Id = 1,
                Name = "Test Update",
                Description = "Test"
            };
            A.CallTo(() => _unitOfWork.SaveChangesAsync()).Throws(new Exception("Error exception"));
            // Act & Assert
            await Assert.ThrowsAsync<InternalServerException>(() => controller.UpdateArea(updateAreaDTO));
        }
        #endregion

        #region DeleteArea
        [Fact]
        public async void AreasController_DeleteArea_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var area = new Area
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(area.Id)).Returns(area);
            // Act
            var result = await controller.DeleteArea(area.Id);
            // Assert
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<object>>().Subject;
            apiResponse.Status.Should().Be(StatusCodes.Status200OK);
            A.CallTo(() => _unitOfWork.AreaRepository.Delete(area.Id)).MustHaveHappened();
        }

        [Fact]
        public async void AreasController_DeleteArea_AreaDoesNotExist_ThrowsBadRequestException()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            Area area = null!;
            A.CallTo(() => _unitOfWork.AreaRepository.GetByIdAsync(1)).Returns(area);
            // Act & Assert
            await Assert.ThrowsAsync<BadRequestException>(() => controller.DeleteArea(1));
        }

        [Fact]
        public async void AreasController_DeleteArea_ThrowsInternalServerError()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            A.CallTo(() => _unitOfWork.AreaRepository.Delete(1)).Throws(new Exception());
            // Act & Assert
            await Assert.ThrowsAsync<InternalServerException>(() => controller.DeleteArea(1));
        }
        #endregion

        #region GetAreasWithEmployees
        [Fact]
        public async void AreasController_GetAreasWithEmployees_ReturnOK()
        {
            // Arrange
            var controller = new AreasController(_unitOfWork, _mapper);
            var areas = new List<Area>
            {
                new Area
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Test",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    Employees = new List<Employee>
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Test",
                            Surname = "Test",
                            Email = "test@test.com",
                            PhoneNumber = "8445676767",
                            CreatedOn = DateTime.Now,
                            Areas = new List<Area>
                            {
                                new Area
                                {
                                    Id = 1,
                                    Name = "Test Area",
                                    CreatedOn = DateTime.Now
                                }
                            }
                        }
                    }
                }
            };
            var areasWithEmployeesDTO = new List<AreaWithEmployeesDTO>
            {
                new AreaWithEmployeesDTO
                {
                    Id = 1,
                    Name = "Test area",
                    Description = "Test area description",
                    Employees = new List<EmployeeForAreaDTO>
                    {
                        new EmployeeForAreaDTO
                        {
                            Name = "Test 1",
                            Surname = "Test",
                        },
                         new EmployeeForAreaDTO
                        {
                            Name = "Test 2",
                            Surname = "Test",
                        }
                    }
                }
            };
            A.CallTo(() => _unitOfWork.AreaRepository.GetAreasWithEmployeesAsync()).Returns(areas);
            A.CallTo(() => _mapper.Map<List<AreaWithEmployeesDTO>>(areas)).Returns(areasWithEmployeesDTO);
            // Act
            var result = await controller.GetAreasWithEmployees();
            // Assert
            var okResponse = result.Should().BeOfType<OkObjectResult>().Subject;
            var apiResponse = okResponse.Value.Should().BeOfType<ApiResponse<List<AreaWithEmployeesDTO>>>().Subject;
            apiResponse.Data.Should().HaveCount(1);
            apiResponse.Data.Should().BeEquivalentTo(areasWithEmployeesDTO);
        }
        #endregion
    }
}
