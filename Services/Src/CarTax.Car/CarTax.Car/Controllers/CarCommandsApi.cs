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



       
        //[HttpPut]
        //public Task<IActionResult> Put(Commands.V1.carCreate request)
        //    => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        //[Route("text")]
        //[HttpPut]
        //public Task<IActionResult> Put(Commands.V1.UpdateText request)
        //    => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        //[Route("price")]
        //[HttpPut]
        //public Task<IActionResult> Put(Commands.V1.UpdatePrice request)
        //    => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        //[Route("requestpublish")]
        //[HttpPut]
        //public Task<IActionResult> Put(Commands.V1.RequestToPublish request)
        //    => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        //[Route("publish")]
        //[HttpPut]
        //public Task<IActionResult> Put(Commands.V1.Publish request)
        //    => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);
    }
}