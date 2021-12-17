using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiServBox.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/flashcall/[controller]")] //check_code'
    [ApiController]
    public class СheckСodeController : ControllerBase
    {
        private readonly ILogger<СheckСodeController> _logger;

        public СheckСodeController(ILogger<СheckСodeController> logger)
        {
            _logger = logger;
        }

        /*[HttpGet]
        public IActionResult test() 
        {
            return Ok(
                new
                {
                    data = new { },
                    success = true,
                    code = 0,
                    time = "2021-03-24T15:56:34+0000"
                });
        }*/

        [HttpPost]
        public IActionResult Get(string phone, string code, string correlationId)
        {
            if (phone!="9091211465" && code != "4457" && correlationId != "ecb04d36-b838-4ace-8c79-10847df26554")
                return BadRequest(new {
                    data = new { },
                    success = false,
                    code = 1,
                    name = "Повторный звонок",
                    message = "Повторный звонок возможен через 120 секунд",
                    time = "2021-03-24T15:56:34+0000"
                });
            return Ok(
                new
                {
                    data = new { },
                    success = true,
                    code = 0,
                    time = "2021-03-24T15:56:34+0000"
                });
        }
    }
}
