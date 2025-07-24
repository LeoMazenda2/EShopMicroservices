namespace Catalog.API.Products.GetProductVyId;

internal class GetProductByIdQueryHandler
    (IDocumentSession session, ILogger<GetProductByIdQueryHandler> logger)
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductByIdQueryHandler.Handle called with {@Query}", query);

        var product = session.LoadAsync<Product>(query.Id, cancellationToken);

        if (product is null)
        {
            logger.LogWarning("Product with Id {Id} not found", query.Id);
            throw new ProductNotFoundException();
        }

    }
}


public record GetProductByIdQuery(Guid Id) : IQuery<GetProductByIdResult>;

public record GetProductByIdResult(Product Product);