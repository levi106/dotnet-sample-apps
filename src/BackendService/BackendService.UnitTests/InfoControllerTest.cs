using BackendService.Controllers.Actuator;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Backend.UnitTests;

public class InfoControllerTest
{
    [Fact]
    public void Get_actuator_info_success()
    {
        var loggerMock = Mock.Of<ILogger<InfoController>>();
        
        var infoController = new InfoController(loggerMock);
        var actionResult = infoController.GetInfo();

        Assert.True(actionResult.ProcessorCount > 0);
    }
}