
namespace Catalog.API.Products.GetProducts;

public record GetProductByIdQuery() : IQuery<GetProductByIdResult>;
public record GetProductByIdResult(IEnumerable<Product> Products);

internal class GetProductByIdQueryHandler
    (IDocumentSession session, ILogger<GetProductByIdQueryHandler> logger)
    : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
{
    public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsQueryHandler.Handle called with {@Query}", query);

        var products = await session.Query<Product>().ToListAsync(cancellationToken);

        return new GetProductByIdResult(products);
    }
}