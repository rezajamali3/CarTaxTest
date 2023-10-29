using System.Data.Common;
using Library_API;
using Microsoft.AspNetCore.Mvc;
using Serilog;



namespace CarTax.Tax.Application
{
    [ApiController, Route("/Combinedstation")]
    public class CombinedstationQueryApi : ControllerBase
    {

        private static Serilog.ILogger _log = Log.ForContext<CombinedstationQueryApi>();

        private readonly DbConnection _connection;

        public CombinedstationQueryApi(DbConnection connection)
            => _connection = connection;

        //[HttpGet]
        //[Route("listCarTaxArea")]
        //public async Task<IActionResult> Get([FromBody] QueryModels.GetPageing request)
        //    => await RequestHandler.HandleQuery(() => _connection.Query(request), _log);

        //[HttpGet]
        //[Route("OwnersCarTaxArea")]
        //public Task<IActionResult> Get([FromQuery] QueryModels.GetPagingCarOwnwer request)
        //    => RequestHandler.HandleQuery(() => _connection.Query(request), _log);

        //[HttpGet]
        //[Route("GetTaxCarAreaId")]
        //public Task<IActionResult> Get([FromQuery] QueryModels.GetTaxCarAreaId request)
        //    => RequestHandler.HandleQuery(() => _connection.Query(request), _log);

        //[HttpGet]
        //[Route("GetTaxDateCar")]
        //public Task<IActionResult> Get([FromQuery] QueryModels.GetTaxDateCar request)
        //   => RequestHandler.HandleQuery(() => _connection.Query(request), _log);
    }
}