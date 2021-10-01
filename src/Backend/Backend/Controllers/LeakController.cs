namespace Backend.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class LeakControlelr : ControllerBase
{
    private readonly ILogger<LeakControlelr> _logger;

    public LeakControlelr(ILogger<LeakControlelr> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
//        _logger.LogInformation("start");
        return "helloworld";
    }
}