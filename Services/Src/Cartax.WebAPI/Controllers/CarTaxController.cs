using AutoMapper;
<<<<<<< HEAD
using Cartax.Applications.Common.Base;
using Cartax.Applications.Services.TaxCarServices.Command;

=======
using Cartax.Applications.Base;
using Cartax.Applications.DTO.Car;
using Cartax.Applications.Services.TaxCarServices;
using Cartax.Applications.Services.TaxCarServices.Command;
using Cartax.Domain.Errors;
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb

using MediatR;

using Microsoft.AspNetCore.Mvc;



namespace Cartax.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTaxController : ControllerBase
    {

        private readonly IMediator _mediator;
<<<<<<< HEAD

        public CarTaxController(IMediator mediator)
       => _mediator = mediator;
=======
        private readonly IMapper _mapper;

        

        public CarTaxController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

        }
>>>>>>> 6e0109040902ca67597d3488cf835a7f8636c8fb


        [HttpPost]
        public   async Task<ActionResult<CommandResponse>> NewCarTaxAsync(int idCar,int idArea,DateTime dateTime ,TimeSpan timeSpan)
        => await  _mediator.Send(new TaxCarCommand(idCar, idArea, dateTime + timeSpan));



    }
}
