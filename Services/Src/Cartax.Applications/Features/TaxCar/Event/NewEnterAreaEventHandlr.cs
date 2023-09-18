using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartax.Domain.Domain.Tax.Event;
using Cartax.Applications.Common.Intercpter;
using Cartax.Domain.Common.Primitives;
using Cartax.Applications.Common.Primitives;

namespace Cartax.Applications.Features.TaxCar.Event
{

    public sealed record NewEnterAreaEventHandlr  : INotificationHandler<NewTaxCarEnterEvent>
    {

        public NewEnterAreaEventHandlr()
        {
            
        }

        public Task Handle(NewTaxCarEnterEvent notification, CancellationToken cancellationToken)
        {
           
            throw new NotImplementedException();
        }

     

    }
}
