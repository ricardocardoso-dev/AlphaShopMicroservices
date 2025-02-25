﻿namespace Basket.API.Basket.GetBasket;

public record GetBasketResult(ShoppingCart Cart);
public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;

public class GetBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        //TODO: get basket from database
        //var basket = await _repository.GetBasket(request.UserName);

        return new GetBasketResult(new ShoppingCart("swn"));
    }
}
