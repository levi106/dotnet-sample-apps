using BackendService5.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackendService5.Controllers.Actuator
{
    [ApiController]
    [Route("api/v1/actuator/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public Info GetInfo()
        {
            return new Info
            {
                ProcessorCount = Environment.ProcessorCount
            };
        }
    }
}
