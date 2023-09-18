using Cartax.Applications.Common.Base;
using MediatR;


namespace Cartax.Applications.Common.Primitives;




public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, CommandResponse>
    where TCommand : ICommend
{

}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, CommandResponse<TResponse>>
    where TCommand : ICommend<TResponse>
{

}









