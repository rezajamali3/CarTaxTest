using Microsoft.AspNetCore.Mvc;




namespace TaxCar.City.Presentation.Controllers
{
    [ApiController, Route("/City")]
    public class CityQueryApi : ControllerBase
    {
        [Route("/City/ChackOut/{id}")]
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