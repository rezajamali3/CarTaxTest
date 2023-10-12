//using System;
//using System.Threading.Tasks;
//using Library_API.EventSoursing;
//using Library_Domain.Interface;
//using Library_Domain.Model;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using NPOI.SS.Formula.Functions;

//namespace Library_API.Api
//{
//    public abstract class CommandApi<T> : ControllerBase
//        where T : IAggregateRoot
//    {
//         private  readonly ILogger _log;

//        // ApplicationService<T> Service { get; }


//        //protected CommandApi(ApplicationService<T> applicationService,
//        //    ILoggerFactory loggerFactory)
//        //{
//        //    _log = loggerFactory.CreateLogger(GetType());
//        //    Service = applicationService;
//        //}

       

//        protected async Task<IActionResult> HandleCommand<TCommand>(
//            TCommand command,
//            Action<TCommand> commandModifier = null)
//        {
//            //try
//            //{
//            //    _log.LogDebug(
//            //        "Handling HTTP request of type {type}", 
//            //        typeof(T).Name
//            //    );
//            //    commandModifier?.Invoke(command);
//            //    await Service.Handle(command);
//            //    return new OkResult();
//            //}
//            //catch (Exception e)
//            //{
//            //    _log.LogError(e, "Error handling the command");

//            //    return new BadRequestObjectResult(
//            //        new
//            //        {
//            //            error = e.Message, 
//            //            stackTrace = e.StackTrace
//            //        }
//            //    );
//            //}
//        }

//        protected Guid GetUserId() => Guid.Parse(User.Identity.Name);
//    }
//}