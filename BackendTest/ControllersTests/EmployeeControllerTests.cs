using Library.Configurations.CacheService;
using Library.Controllers;
using Library.Models.Employee;
using Library.Repositories;
using Library.UnitsOfWork.EmployeeUoW;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Moq;
using MySqlX.XDevAPI.Common;
using System.Net;
using System.Text.Json;

namespace BackendTest.ControllersTests;

[Collection("IntegrationTests")]
public class EmployeeControllerTests
{
    public Mock<IEmployeeUnitOfWork> _unitOfWorkMock = new();
    public Mock<ICacheService> _cacheServiceMock = new();
    public Mock<IEmployeeRepository> _repositoryMock = new();

    [Fact]
    public async Task Login_ReturnsLoginInfoAndToken()
    {
        LoginInfoDTO loginResponse = new() { First_Name = "rawad", Last_Name = "azzam", Position = "manager", Token = "token"};
        LoginRequestDTO loginRequest = new() { Username = "rawad123" , Password = "1234" };

        _repositoryMock.Setup(x => x.GetLoginInfoAsync(It.IsAny<string>())).ReturnsAsync(loginResponse);

        _unitOfWorkMock.Setup(x => x.GetEmployeeLoginInfo(loginRequest.Username, loginRequest.Password))
            .ReturnsAsync(await _repositoryMock.Object.GetLoginInfoAsync(It.IsAny<string>()));

        var controller = new EmployeeController(_unitOfWorkMock.Object, _cacheServiceMock.Object);

        var result = (await controller.EmployeeLogin(loginRequest)).Result;
        
        Assert.NotNull(result);

        result = (ViewResult) result;

        var viewResult = Assert.IsType<ViewResult>(result);

        var model = Assert.IsAssignableFrom<LoginInfoDTO>(
        viewResult.ViewData.Model);

        Assert.NotNull(model);
        Assert.Equal("token", model.Token);

    }
}
