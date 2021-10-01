namespace BackendService.FunctionalTests;

using Backend.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public ApiTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Can_Get_Actuator_Info()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetFromJsonAsync<Info>("/api/v1/actuator/info");

        // Assert
        Assert.True(response?.ProcessorCount > 0);
    }
}
