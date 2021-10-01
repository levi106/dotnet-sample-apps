namespace Backend.Controllers.Actuator;

using Backend.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
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
        return new Info
        {
            ProcessorCount = Environment.ProcessorCount
        };
    }
}