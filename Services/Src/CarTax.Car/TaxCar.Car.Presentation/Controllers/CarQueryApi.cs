using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace CarTax.Car.Application
{
    [ApiController, Route("/Cars")]
    public class CarQueryApi : ControllerBase
    {



        [Route("/Cars/ChackOut/{id}")]
        [HttpGet]

        public async Task<ActionResult> Get([FromRoute] int id)
        {
            var result = new
            {
                IsChack = await Task<bool>.Factory.StartNew(() => { return true; })
            };
            return Ok(result);
        }

    }
}