using AutoMapper;


using MediatR;

using Microsoft.AspNetCore.Mvc;



namespace Cartax.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTaxController : ControllerBase
    {

        private readonly IMediator _mediator;


        public CarTaxController(IMediator mediator)
       => _mediator = mediator;

        private readonly IMapper _mapper;

        

        public CarTaxController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

        }

        //[HttpPost]
        //public   async Task<ActionResult<CommandResponse>> NewCarTaxAsync(int idCar,int idArea,DateTime dateTime ,TimeSpan timeSpan)
        //=> await  _mediator.Send(new TaxCarCommand(idCar, idArea, dateTime + timeSpan));



    }
}
