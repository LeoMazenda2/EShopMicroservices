using BuildingBlocks.CQRS.Commands;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name,List<string> Category, string Description, string ImageFile, decimal Price) 
    : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductHandler(IDocumentSession session) 
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

        //Save product to the database with Marten ORM
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        //Return the result with the new product Id
        return new CreateProductResult(Guid.NewGuid());
    }
}