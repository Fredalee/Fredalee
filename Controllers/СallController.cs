using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServBox.Models.Answers;

namespace WebApiServBox.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/flashcall/[controller]")]
    [ApiController]
    public class СallController : ControllerBase
    {
        private readonly ILogger<СallController> _logger;

        public СallController(ILogger<СallController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Answer Call(string phone, string type)
        { 
            if (phone != "9091211465" && type != "authCall")
            {
                return null;
            } 
            else
            {
                var answer = new Answer()
                {
                    data = new Data()
                    {
                        expiresIn = 120,
                        correlationId = "ecb04d36-b838-4ace-8c79-10847df26554"
                    },
                    success = true,
                    code = 0,
                    name = "",
                    message = "",
                    time = "2021-03-24T15:55:07+0000"
                };
                return answer;
            }
        }
    }
}
