using Cartax.Applications.Common.Base;
using MediatR;



namespace Cartax.Applications.Common.Primitives;
public interface IQueryHandlers<TQuere, TResponse>
    : IRequestHandler<TQuere, CommandResponse<TResponse>>
    where TQuere : IQuery<TResponse>
{
}

