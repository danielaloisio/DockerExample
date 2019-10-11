using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TarefaDocker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateTimeDockerController : ControllerBase
    {
        [HttpGet("data")]
        public ActionResult<string> GetDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
