using System.Threading.Tasks;
using CarTax.Car.Application;

using CarTax.CarType.Application;
using CarTax.City.Message;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace CarTax.City.Controllers
{
    [Route("/City")]
    public class CarCommandsApi : ControllerBase
    {
       private readonly CityApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<CarCommandsApi>();

        public CarCommandsApi(
            CityApplicationService applicationService)
            => _applicationService = applicationService;



        [Route("NewCar")]
        [HttpPost]
        public Task<IActionResult> Post(Commands.V1.NewCity request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);



        [Route("ChanchDetailsCity")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.ChanchDetailsCity request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.CityActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDeActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.CityDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("CarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete(Commands.V1.CityDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

      
    }
}