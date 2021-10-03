namespace BackendService.Controllers.Actuator;

using Backend.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/actuator/[controller]")]
public class InfoController : ControllerBase
{
    private readonly ILogger<InfoController> _logger;

    public InfoController(ILogger<InfoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Info GetInfo()
    {
        _logger.LogInformation("GetInfo");
        return new Info
        {
            ProcessorCount = Environment.ProcessorCount
        };
    }
}