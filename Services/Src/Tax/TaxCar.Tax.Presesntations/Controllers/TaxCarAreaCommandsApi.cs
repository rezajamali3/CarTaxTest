
using Library_API;
using Microsoft.AspNetCore.Mvc;
using TaxCar.Tax.Application;
using static TaxCar.Tax.Message.Commands;

namespace TaxCar.Tax.Presesntations.Controllers
{
    [Route("/Tax")]
    public class TaxCarAreaCommandsApi : ControllerBase
    {
       private readonly TaxCarAreaApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<TaxCarAreaCommandsApi>();

        public TaxCarAreaCommandsApi(
            TaxCarAreaApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("newTax")]
        [HttpPost]
        public Task<IActionResult> Post(V1.newTax request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

  
        [Route("DeleteTax")]
        [HttpDelete]
        public Task<IActionResult> Delete(V1.DeleteTax request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

    }
}