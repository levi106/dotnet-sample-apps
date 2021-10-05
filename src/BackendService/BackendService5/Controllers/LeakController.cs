using Microsoft.AspNetCore.Mvc;

namespace BackendService5.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LeakController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Ok";
        }
    }
}
