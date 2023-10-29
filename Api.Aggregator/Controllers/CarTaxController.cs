using Api.Aggregator.Configuratuins.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Aggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTaxController : ControllerBase
    {

        private readonly ICarService _catalogService;
       

        public CarTaxController(ICarService carService)
        {
            _catalogService = carService;
     
        }

        [HttpGet("{id}", Name = "GetCar")]
        [ProducesResponseType(typeof(CarDtails), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CarDtails>> GetCar(int id)
        {
            var Car = await _catalogService.GetCarDtails(id);
            return Ok(Car);
        }



    }
}
