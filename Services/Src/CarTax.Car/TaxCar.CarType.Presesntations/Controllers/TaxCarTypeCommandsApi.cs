using CarTax.CarType.Application;
using CarTax.CarType.Message;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Library_API;

namespace CarTax.CarType.Controllers
{
    [Route("/taxcartype")]
    [ApiController]
    public class TaxCarTypeCommandsApi : ControllerBase
    {

        private readonly CarTypeApplicationService _applicationService;
        private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<TaxCarTypeCommandsApi>();

        public TaxCarTypeCommandsApi(CarTypeApplicationService applicationService)
        => _applicationService = applicationService;


        [Route("NewTaxCarType")]
        [HttpPost]
        public Task<IActionResult> Post([FromBody] Commands.V1.NewTaxCarType request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("ChancheCarTypeName")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] Commands.V1.ChancheCarTypeName request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("TaxCarTypeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromServices] Commands.V1.TaxCarTypeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeDeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] Commands.V1.TaxCarTypeDeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeTaxActive")]
        [HttpPatch]
        public Task<IActionResult> Patch(Commands.V1.TaxCarTypeTaxActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeTaxDeActive")]
        [HttpPatch]
        public Task<IActionResult> Patch([FromBody] Commands.V1.TaxCarTypeTaxDeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeDelete")]
        [HttpDelete]
        public Task<IActionResult> Put([FromBody] Commands.V1.TaxCarTypeDelete request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


    }
}
