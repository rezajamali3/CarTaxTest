using AutoMapper;
using Cartax.Domain.Common.Primitives;
using Cartax.Domain.Domain.Tax.Event;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cartax.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IDomainEventAdd DomainEvent;



        public CarController(IMediator mediator, IMapper mapper, IDomainEventAdd domainEvent)
        {
            _mediator = mediator;
            _mapper = mapper;
            DomainEvent = domainEvent;
        }



        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            return Ok();
        }

        // POST api/<CarController>
        [HttpPost]
        public ActionResult Post()
        {
            DomainEvent.StartEvent(new NewTaxCarEnterEvent());
            return Ok();
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
