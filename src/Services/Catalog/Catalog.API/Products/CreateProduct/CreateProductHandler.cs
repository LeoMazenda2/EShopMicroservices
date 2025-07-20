using BuildingBlocks.CQRS.Commands;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name,List<string> Category, string Description, string ImageFile, decimal Price) 
    : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductHandler 
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // Business logicc to create product

        var product = new Product {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        return new CreateProductResult(Guid.NewGuid());
    }
}