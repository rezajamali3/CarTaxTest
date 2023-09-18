using Cartax.Applications.Common.Base;
using MediatR;


namespace Cartax.Applications.Common.Primitives;

public interface ICommend : IRequest<CommandResponse>
{

}


public interface ICommend<TResponse> : IRequest<CommandResponse<TResponse>>
{
}


public interface ICommend<TCommand, TResponse> : IRequest<CommandResponse<TResponse>>
{

}



