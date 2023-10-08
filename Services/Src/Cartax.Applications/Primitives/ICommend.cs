using Cartax.Applications.Base;
using MediatR;


namespace Cartax.Applications.Primitives;

public interface ICommend : IRequest<CommandResponse>
{

}


public interface ICommend<TResponse> : IRequest<CommandResponse<TResponse>>
{
}


public interface ICommend<TCommand, TResponse> : IRequest<CommandResponse<TResponse>>
{

}



