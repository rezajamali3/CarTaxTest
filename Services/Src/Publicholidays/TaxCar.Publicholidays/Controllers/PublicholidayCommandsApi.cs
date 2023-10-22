using System.Threading.Tasks;
using CarTax.Car.Application;
using CarTax.Publicholiday.Application;

using CarTax.Publicholiday.Application;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TaxCar.Publicholidays.Message;

namespace CarTax.Car.Controllers
{
    [Route("/Publicholiday")]
    public class PublicholidayCommandsApi : ControllerBase
    {
       private readonly PublicholidayApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<PublicholidayCommandsApi>();

        public PublicholidayCommandsApi(PublicholidayApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("Definitionofpublicholidays")]
        [HttpPost]
        public Task<IActionResult> Post(Commands.V1.Definitionofpublicholidays request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("ChanchDetailsofpublicholidays")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.ChanchDetailsofpublicholidays request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("publicholidaysActive")]
        [HttpPatch]
        public Task<IActionResult> Patch(Commands.V1.publicholidaysActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("publicholidaysDeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch(Commands.V1.publicholidaysDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("Deleteofpublicholidays")]
        [HttpDelete]
        public Task<IActionResult> Delete(Commands.V1.Deleteofpublicholidays request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


    }
}