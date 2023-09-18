using Cartax.Applications.Common.Base;
using Cartax.Domain.Common.Primitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartax.Applications.Common.Primitives
{
    public interface IDomainNotificationHandler<IDomainEvent> : INotificationHandler<IDomainEvent>
    where IDomainEvent : IDomainNotification
    { 
    }
}
