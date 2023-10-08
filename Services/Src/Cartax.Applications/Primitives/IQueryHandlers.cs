using Cartax.Applications.Base;
using MediatR;



namespace Cartax.Applications.Primitives;
public interface IQueryHandlers<TQuere, TResponse>
    : IRequestHandler<TQuere, CommandResponse<TResponse>>
    where TQuere : IQuery<TResponse>
{
}

