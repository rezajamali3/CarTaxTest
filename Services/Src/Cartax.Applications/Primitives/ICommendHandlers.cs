using Cartax.Applications.Base;
using MediatR;


namespace Cartax.Applications.Primitives;




public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, CommandResponse>
    where TCommand : ICommend
{

}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, CommandResponse<TResponse>>
    where TCommand : ICommend<TResponse>
{

}









