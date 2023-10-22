using System.Threading.Tasks;
using CarTax.Car.Application;


using CarTax.Taxfreecar.Message;
using CarTax.Taxfreecar.Aplication;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace CarTax.City.Controllers
{
    [Route("/Taxfreecar")]
    public class TaxfreecarCommandsApi : ControllerBase
    {
       private readonly TaxfreecarApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<TaxfreecarCommandsApi>();

        public TaxfreecarCommandsApi(
            TaxfreecarApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("NewTaxfreecar")]
        [HttpPost]
        public Task<IActionResult> Post(Commands.V1.NewTaxfreecar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("ChancheTaxfreecar")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.ChancheTaxfreecar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.TaxfreecarActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarDeActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.TaxfreecarDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete(Commands.V1.TaxfreecarDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

    }
}