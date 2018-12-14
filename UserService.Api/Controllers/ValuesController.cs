using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace UserService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET api/values
        [HttpGet("{key}")]
        public IActionResult Get(string key)
        {
            return Json(_configuration[key]);
        }
    }
}
