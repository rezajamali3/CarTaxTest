using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using CarTax.Area.Message;
using CarTax.Area.Message.Projections;
using Library_API;
using Library_Dapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace CarTax.Area.Application
{
    [ApiController, Route("/Area")]
    public class AreaQueryApi : ControllerBase
    {
        private static Serilog.ILogger _log = Log.ForContext<AreaQueryApi>();

        private readonly IDbConnection _connection;

        public AreaQueryApi(IDbConnection connection)
            => _connection = connection;


        [HttpGet]
        [Route("ExistsAreaId")]
        public async Task<IActionResult> Get([FromQuery] QueryModels.ExistsAreaId request)
            => await RequestHandler.HandleQuery(() => _connection.Query(request), _log);
    }
}