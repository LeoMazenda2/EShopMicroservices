using MediatR;

namespace BuildingBlocks.CQRS.Commands;


public interface ICommand : IRequest<Unit>
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
