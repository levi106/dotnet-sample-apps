namespace BackendService.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class LeakController : ControllerBase
{
    private readonly ILogger<LeakController> _logger;

    public LeakController(ILogger<LeakController> logger)
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