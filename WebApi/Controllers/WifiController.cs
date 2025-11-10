using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WifiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Ok = true });
        }
    }
}
