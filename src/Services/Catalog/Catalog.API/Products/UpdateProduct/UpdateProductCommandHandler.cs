﻿namespace Catalog.API.Products.UpdateProduct;

public record UpdateProductResult(bool IsSuccess);

public record UpdateProductCommand(Guid Id, string Name, List<string> Category, string description, string ImageFile, decimal Price)
    : ICommand<UpdateProductResult>;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Product Id is required");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required")
            .Length(1, 150).WithMessage("Name must be between 2 and 150 characters");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0");
    }
}

internal class UpdateProductCommandHandler(IDocumentSession session, ILogger<UpdateProductCommandHandler> logger)
    : ICommandHandler<UpdateProductCommand, UpdateProductResult>
{
    public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("UpdateProductCommandHandler.Handle called with {@Command}", command);

        var product = await session.LoadAsync<Product>(command.Id, cancellationToken);
        if (product is null)
            throw new ProductNotFoundException(command.Id);

        product.Name = command.Name;
        product.Category = command.Category;
        product.Description = command.description;
        product.ImageFile = command.ImageFile;
        product.Price = command.Price;

        session.Update(product);
        await session.SaveChangesAsync(cancellationToken);

        return new UpdateProductResult(true);
    }
}
