using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Domain.Products;
using Domain.Shared;

namespace Application.Orders.PlaceCustomerOrder
{
    public static class ProductPriceProvider
    {
        public static async Task<List<ProductPriceData>> GetAllProductPrices(IDbConnection connection)
        {
            var productPrices = await connection.QueryAsync<ProductPriceResponse>("SELECT " +
                                                                                  $"[ProductPrice].ProductId AS [{nameof(ProductPriceResponse.ProductId)}], " +
                                                                                  $"[ProductPrice].Value AS [{nameof(ProductPriceResponse.Value)}], " +
                                                                                  $"[ProductPrice].Currency AS [{nameof(ProductPriceResponse.Currency)}] " +
                                                                                  "FROM orders.v_ProductPrices AS [ProductPrice]");

            return productPrices.AsList()
                .ConvertAll(x => new ProductPriceData(
                    new ProductId(x.ProductId),
                    MoneyValue.Of(x.Value, x.Currency)))
;
        }

        private sealed class ProductPriceResponse
        {
            public Guid ProductId { get; set; }

            public decimal Value { get; set; }

            public string Currency { get; set; }
        }
    }
}