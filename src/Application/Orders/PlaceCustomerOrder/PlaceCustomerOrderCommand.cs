using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;

namespace Application.Orders.PlaceCustomerOrder
{
    public class PlaceCustomerOrderCommand : CommandBase<Guid>
    {
        public Guid CustomerId { get; }

        public List<ProductDto> Products { get; }

        public string Currency { get; }

        public PlaceCustomerOrderCommand(Guid customerId, List<ProductDto> products, string currency)
        {
            this.CustomerId = customerId;
            this.Products = products;
            this.Currency = currency;
        }
    }
}