

using Library_API;
using Library_Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using static TaxCar.Combinedstation.Applaication.Feature.Commands;


namespace CarTax.Tax.Controllers
{
    [Route("/Combinedstation")]
    public class CombinedstationCommandsApi : ControllerBase
    {

        private readonly IApplicationService _applicationService;
        private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<CombinedstationCommandsApi>();


        public CombinedstationCommandsApi(IApplicationService applicationService)
            => _applicationService = applicationService;


        [Route("NewCombinedstation")]
        [HttpPost]
        public Task<IActionResult> Post([FromBody] V1.Create request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("UpdateCombinedstation")]
        [HttpPut]
        public Task<IActionResult> Put([FromBody] V1.Update request)
               => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);


        [Route("DeleteCombinedstation")]
        [HttpDelete]
        public Task<IActionResult> Delete([FromBody] V1.Delete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);




    }
}