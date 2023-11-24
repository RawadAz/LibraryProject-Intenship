using Library.Configurations.CacheService;
using Library.Controllers;
using Library.Models.Employee;
using Library.UnitsOfWork.EmployeeUoW;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace BackendTest.ControllersTests;

[Collection("IntegrationTests")]
public class EmployeeControllerTests
{
    public Mock<IEmployeeUnitOfWork> _unitOfWorkMock = new();
    public Mock<ICacheService> _cacheServiceMock = new();


    [Fact]
    public async void Login_ReturnsLoginInfoAndTokenIfValid()
    {
        LoginInfoDTO loginResponse = new() { First_Name = "rawad", Last_Name = "azzam", Position = "manager", Token = "token" };
        LoginRequestDTO loginRequest = new() { Username = "rawad123", Password = "1234" };

        _unitOfWorkMock.Setup(x => x.GetEmployeeLoginInfo(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(loginResponse);

        var controller = new EmployeeController(_unitOfWorkMock.Object, _cacheServiceMock.Object);

        ActionResult<LoginInfoDTO> result = await controller.EmployeeLogin(loginRequest);

        Assert.NotNull(result);
        Assert.NotNull(result.Result);

        OkObjectResult actualResult = (OkObjectResult) result.Result;

        Assert.Equal(200, actualResult.StatusCode);
        Assert.NotNull(actualResult.Value);

        LoginInfoDTO loginResult = (LoginInfoDTO) actualResult.Value;
        Assert.Equal(loginResponse, loginResult);
    }

    [Fact]
    public async void Login_ReturnsBadRequestWhenNullInfo() 
    {
        LoginRequestDTO loginRequest = new() { Username = null, Password = null };

        _unitOfWorkMock.Setup(x => x.GetEmployeeLoginInfo(It.IsAny<string>(), It.IsAny<string>()));
        var controller = new EmployeeController(_unitOfWorkMock.Object, _cacheServiceMock.Object);

        ActionResult<LoginInfoDTO> result = await controller.EmployeeLogin(loginRequest);

        Assert.NotNull(result);
        Assert.NotNull(result.Result);

        BadRequestObjectResult actualResult = (BadRequestObjectResult) result.Result;

        Assert.Equal(400, actualResult.StatusCode);
    }

}
