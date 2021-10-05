using BackendService5.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
using Xunit;

namespace BackendService5.FunctionalTests
{
    public class ApiTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ApiTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void Can_Get_Actuator_Info_v1()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetFromJsonAsync<Info>("/api/v1/actuator/info");

            // Assert
            Assert.True(response?.ProcessorCount > 0);
        }
    }
}
