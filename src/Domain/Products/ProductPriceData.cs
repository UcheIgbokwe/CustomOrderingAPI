using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;
using Domain.Shared;

namespace Domain.Products
{
    public class ProductPriceData : ValueObject
    {
        public ProductPriceData(ProductId productId, MoneyValue price)
        {
            ProductId = productId;
            Price = price;
        }

        public ProductId ProductId { get; }

        public MoneyValue Price { get; }
    }
}