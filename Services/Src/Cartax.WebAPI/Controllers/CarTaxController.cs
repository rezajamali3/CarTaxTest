using AutoMapper;
using Cartax.Applications.Common.Base;
using Cartax.Applications.DTO.Car;
using Cartax.Applications.Features.TaxCar.Event;
using Cartax.Applications.Services.TaxCarServices;
using Cartax.Applications.Services.TaxCarServices.Command;
using Cartax.Domain.Common.Primitives;
using Cartax.Domain.Domain.Tax.Event;
using MediatR;

using Microsoft.AspNetCore.Mvc;
using System;


namespace Cartax.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTaxController : ControllerBase
    {


        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IDomainEventAdd DomainEvent;



        public CarTaxController(IMediator mediator, IMapper mapper,IDomainEventAdd domainEvent)
        {
            _mediator = mediator;
            _mapper = mapper;
             DomainEvent = domainEvent;
        }


        [HttpGet]
        public IActionResult Get()
        {

            DomainEvent.StartEvent(new NewTaxCarEnterEvent());
            return Ok();
        }


        [HttpPost]
        public   async Task<ActionResult<CommandResponse>> NewCarTaxAsync(int idCar,int idArea,DateTime dateTime ,TimeSpan timeSpan)
        {

            DateTime combinedDateTime = dateTime + timeSpan;
            var result =await  _mediator.Send(new TaxCarCommand(idCar, idArea, combinedDateTime));

            return Ok(result);

        }


    }
}
