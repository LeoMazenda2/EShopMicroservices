using MediatR;

namespace BuildingBlocks.CQRS.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
{
}
