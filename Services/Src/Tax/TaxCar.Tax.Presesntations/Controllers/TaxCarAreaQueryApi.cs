
using System.Data.Common;
using Dapper;
using Library_API;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TaxCar.Tax.Message.Projections;
using static TaxCar.Tax.Message.Projections.ReadModels;

namespace TaxCar.Tax.Presesntations.Controllers
{
    [ApiController, Route("/Tax")]
    public class TaxCarAreaQueryApi : ControllerBase
    {

        private static Serilog.ILogger _log = Log.ForContext<TaxCarAreaQueryApi>();

        private readonly DbConnection _connection;

        public TaxCarAreaQueryApi(DbConnection connection)
            => _connection = connection;


        [HttpGet]
        [Route("listCarTaxArea")]
        public async Task<IActionResult> Get([FromQuery] QueryModels.GetPageing request)
            => await RequestHandler.HandleQuery(() => _connection.Query(request), _log);


        [HttpGet]
        [Route("OwnersCarTaxArea")]
        public Task<IActionResult> Get([FromQuery] QueryModels.GetPagingCarOwnwer request)
            => RequestHandler.HandleQuery(() => _connection.Query(request), _log);


        [HttpGet]
        [Route("GetTaxCarAreaId")]
        public Task<IActionResult> Get([FromQuery] QueryModels.GetTaxCarAreaId request)
            => RequestHandler.HandleQuery(() => _connection.Query(request), _log);


        [HttpGet]
        [Route("GetTaxDateCar")]
        public Task<IActionResult> Get([FromQuery] QueryModels.GetTaxDateCar request)
           => RequestHandler.HandleQuery(() => _connection.Query(request), _log);
    }
}