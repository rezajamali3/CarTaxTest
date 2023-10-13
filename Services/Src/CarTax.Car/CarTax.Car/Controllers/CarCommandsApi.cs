using System.Threading.Tasks;
using CarTax.Car.Application;
using CarTax.Car.Message;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace CarTax.Car.Controllers
{
    [Route("/car")]
    public class CarCommandsApi : ControllerBase
    {
       private readonly CarApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<CarCommandsApi>();

        public CarCommandsApi(
            CarApplicationService applicationService)
            => _applicationService = applicationService;



        [Route("NewCar")]
        [HttpPost]
        public Task<IActionResult> Post(Commands.V1.NewCar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);



        [Route("ChanchDetailsCar")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.ChanchDetailsCar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.CarActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDeActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.CarDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete(Commands.V1.CarDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

      
    }
}