using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DevFreela.API.Controllers
{
    [Route("api/skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        // GET api/skills
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok();
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
