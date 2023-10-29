
using CarTax.Car.Application;
using Library_API;
using Microsoft.AspNetCore.Mvc;
using static CarTax.Car.Message.Commands;

namespace CarTax.Car.Controllers
{
    [Route("/Cars")]
    public class CarCommandsApi : ControllerBase
    {
       private readonly CarApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<CarCommandsApi>();

        public CarCommandsApi(CarApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("NewCar")]
        [HttpPost]
        public Task<IActionResult> Post([FromBody] V1.NewCar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("ChanchDetailsCar")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] V1.ChanchDetailsCar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] V1.CarActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] V1.CarDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete([FromBody] V1.CarDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

    }
}