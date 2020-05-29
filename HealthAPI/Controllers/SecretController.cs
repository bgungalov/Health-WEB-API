using System;
using Microsoft.AspNetCore.Mvc;
using HealthAPI.Filters;

namespace HealthAPI.Controllers
{
    [ApiKeyAuth]
    public class SecretController : ControllerBase
    {
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            return Ok("I have no secrets");
        }
    }
}
