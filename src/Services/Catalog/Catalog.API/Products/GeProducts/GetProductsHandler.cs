﻿using BuildingBlocks.CQRS.Queries;
using Marten.Linq.QueryHandlers;

namespace Catalog.API.Products.GeProducts;

public record GetProductsQuery() : IQuery<GetProductsResult>;
public record GetProductsResult(IEnumerable<Product> Products);

internal class GetProductsQueryHandler(IDocumentSession session, ILogger<GetProductsQueryHandler> logger)
    : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsQueryHandle.Hanle called with {@query}", query);
        
        var protucts = await session.Query<Product>().ToListAsync(cancellationToken);

        return new GetProductsResult(protucts);
    }
}
