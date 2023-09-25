using AutoMapper;
using Cartax.Applications.Base;
using Cartax.Applications.DTO.Car;
using Cartax.Applications.Services.TaxCarServices;
using Cartax.Applications.Services.TaxCarServices.Command;
using Cartax.Domain.Errors;

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

        

        public CarTaxController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

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
