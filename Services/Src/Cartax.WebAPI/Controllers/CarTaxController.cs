using AutoMapper;
using Cartax.Applications.Common.Base;
using Cartax.Applications.Services.TaxCarServices.Command;


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


        [HttpPost]
        public   async Task<ActionResult<CommandResponse>> NewCarTaxAsync(int idCar,int idArea,DateTime dateTime ,TimeSpan timeSpan)
        => await  _mediator.Send(new TaxCarCommand(idCar, idArea, dateTime + timeSpan));



    }
}
