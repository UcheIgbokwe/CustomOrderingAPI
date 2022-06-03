using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Shared;

namespace Domain.Products
{
    public class ProductPrice
    {
        public MoneyValue Value { get; private set; }

        private ProductPrice()
        {
        }
    }
}