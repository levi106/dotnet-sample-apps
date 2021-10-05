using BackendService5.Controllers.Actuator;
using Xunit;

namespace BackendService5.UnitTests
{
    public class InfoControllerTest
    {
        [Fact]
        public void Get_actuator_info_success()
        {
            // Arrange
            var infoController = new InfoController();

            // Act
            var actionResult = infoController.GetInfo();

            // Assert
            Assert.True(actionResult.ProcessorCount > 0);
        }
    }
}
