using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Products;

namespace Domain.Customers.Orders
{
    public class OrderProductData
    {
        public OrderProductData(ProductId productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public ProductId ProductId { get; }

        public int Quantity { get; }
    }
}