using System.Threading.Tasks;
using CarTax.Car.Application;


using CarTax.Area.Message;

using Microsoft.AspNetCore.Mvc;
using Serilog;
using CarTax.Area.Application;
using static CarTax.Area.Message.Events.V1;

namespace CarTax.City.Controllers
{
    [Route("/Area")]
    public class AreaCommandsApi : ControllerBase
    {
       private readonly AreaApplicationService _applicationService;
       private static readonly Serilog.ILogger Log = Serilog.Log.ForContext<AreaCommandsApi>();

        public AreaCommandsApi(AreaApplicationService applicationService)
            => _applicationService = applicationService;

        [Route("NewArea")]
        [HttpPost]
        public Task<IActionResult> Post(NewArea request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("ChanchDetailsArea")]
        [HttpPut]
        public Task<IActionResult> Put(ChanchDetailsArea request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("AreaActive")]
        [HttpPut]
        public Task<IActionResult> Put(AreaActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("AreaDeActive")]
        [HttpPut]
        public Task<IActionResult> Put(AreaDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("AreaDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete(AreaDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);







        [Route("Newspecifiedhourstax")]
        [HttpPost]
        public Task<IActionResult> Post(Newspecifiedhourstax request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("Deletespecifiedhourstax")]
        [HttpDelete]
        public Task<IActionResult> Delete(Deletespecifiedhourstax request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);








        [Route("NewTaxfreecar")]
        [HttpPost]
        public Task<IActionResult> Post(NewTaxfreecar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("ChancheTaxfreecar")]
        [HttpPut]
        public Task<IActionResult> Put(ChancheTaxfreecar request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarActive")]
        [HttpPut]
        public Task<IActionResult> Put(TaxfreecarActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarDeActive")]
        [HttpPut]
        public Task<IActionResult> Put(TaxfreecarDeActive request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

        [Route("TaxfreecarDelete")]
        [HttpDelete]
        public Task<IActionResult> Delete(TaxfreecarDelete request)
            => RequestHandler.HandleCommand(request, _applicationService.Handle, Log);

    }
}