using CarTax.CarType.Application;
using CarTax.CarType.Message;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarTax.CarType.Controllers
{
    [Route("taxcartype")]
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
        [HttpPut]
        public Task<IActionResult> Put([FromServices] Commands.V1.TaxCarTypeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeDeActive")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] Commands.V1.TaxCarTypeDeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeTaxActive")]
        [HttpPut]
        public Task<IActionResult> Put(Commands.V1.TaxCarTypeTaxActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeTaxDeActive")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] Commands.V1.TaxCarTypeTaxDeActive request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxCarTypeDelete")]
        [HttpDelete]
        public Task<IActionResult> Put([FromBody] Commands.V1.TaxCarTypeDelete request)
        => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


    }
}
