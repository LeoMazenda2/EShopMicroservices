using MediatR;

namespace BuildingBlocks.CQRS;

public interface IQueryICommand<out TResponse> : IRequest<TResponse> where TResponse : class
{
}
