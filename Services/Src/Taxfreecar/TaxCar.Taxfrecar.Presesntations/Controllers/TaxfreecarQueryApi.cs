using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace TaxCar.Taxfrecar.Presesntations.Controllers
{
    [ApiController, Route("/Taxfreecar")]
    public class TaxfreecarQueryApi : ControllerBase
    {
        [Route("/Taxfreecar/ChackOut/{id}")]
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