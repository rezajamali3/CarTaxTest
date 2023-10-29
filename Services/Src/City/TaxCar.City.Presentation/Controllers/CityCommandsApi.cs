



using Library_API;
using Microsoft.AspNetCore.Mvc;

using CarTax.City.Application;
using static CarTax.City.Message.Commands;
namespace TaxCar.City.Presentation.Controllers
{
    [Route("/City")]
    public class CityCommandsApi : ControllerBase
    {
       private readonly CityApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<CityCommandsApi>();

        public CityCommandsApi(
            CityApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("NewCar")]
        [HttpPost]
        public Task<IActionResult> Post([FromBody] V1.NewCity request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("ChanchDetailsCity")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] V1.ChanchDetailsCity request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] V1.CityActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] V1.CityDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete([FromBody] V1.CityDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

    }
}