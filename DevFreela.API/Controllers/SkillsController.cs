using DevFreela.Application.Models;
using DevFreela.Application.Services;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _service;
        private readonly IMediator _mediator;
        public SkillsController(ISkillService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }

        // GET api/skills
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            var result = _mediator.Send(GetAll());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = _service.GetById(id);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);
        }

        // POST api/skills
        [HttpPost]
        public IActionResult Post(CreateSkillInputModel model)
        {
            var result = _service.Insert(model);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, model);
        }
    }
}
