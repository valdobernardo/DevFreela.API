using DevFreela.Application.Models;
using DevFreela.Application.Services;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result= _service.GetById(id);

            if (!result.IsSuccess) return BadRequest(result.Message);

            return Ok(result.Data);
      
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
           
            var result = _service.Insert(model);

            if (!result.IsSuccess) return BadRequest(result.Message);

            return NoContent();
        }

        [HttpPost("{id}/skills")]
        public IActionResult PostSkills(int id, UserSkillsInputModel model)
        {
            var result = _service.PostSkills(model);

            if (!result.IsSuccess) return BadRequest(result.Message);

            return NoContent();
        }

    }
}
