using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace CarTax.Car.Application
{
    [ApiController, Route("/ad")]
    public class CarQueryApi : ControllerBase
    {


        //readonly Func<IAsyncDocumentSession> _getSession;


        //public ClassifiedAdsQueryApi(Func<IAsyncDocumentSession> getSession) 
        //    => _getSession = getSession;


        //[HttpGet]
        //public Task<ActionResult<ReadModels.ClassifiedAdDetails>> Get(
        //    [FromQuery] QueryModels.GetPublicClassifiedAd request)
        //    => _getSession.RunApiQuery(s => s.Query(request));


    }
}