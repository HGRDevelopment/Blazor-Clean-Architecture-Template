using HGR.Application.Dummy.Commands;
using HGR.Application.Dummy.Queries;
using HGR.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HGR.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DummyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<DummyController>
        [HttpGet]
        public async Task<List<Dummyentitiy>> Get()
        {
            return await _mediator.Send(new GetDummyListQuery());
        }

        // GET api/<DummyController>/5
        [HttpGet("{id}")]
        public async Task<Dummyentitiy> Get(int id)
        {
            return await _mediator.Send(new GetDummyById(id));
        }

        // POST api/<DummyController>
        [HttpPost]
        public async Task<Dummyentitiy> Post([FromBody] Dummyentitiy model)
        {
            return await _mediator.Send(new CreateDummyCommand(model.Name, model.Email));
        }

        // PUT api/<DummyController>/5
        [HttpPut("{id}")]
        public async Task<Dummyentitiy> Put(int id, string name, string email)
        {
            return await _mediator.Send(new UpdateDummyCommand(id, name, email));
        }

        // DELETE api/<DummyController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _mediator.Send(new DeleteDummyCommand(id));
        }
    }
}
