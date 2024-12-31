namespace Catalog.API.Products.GetProductsByCategory;

public record GetProductsByCategoryResult(IEnumerable<Product> Products);
public record GetProductsByCategoryQuery(string Category) : IQuery<GetProductsByCategoryResult>;

public class GetProductsByCategoryQueryHandler
    (IDocumentSession session)
    : IQueryHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
{
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        var products = await session.Query<Product>()
                                    .Where(p => p.Category.Contains(query.Category))
                                    .ToListAsync(token: cancellationToken);

        return new GetProductsByCategoryResult(products);
    }
}
