using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;
using MediatR;

namespace Application.Orders.ChangeCustomerOrder
{
    public class ChangeCustomerOrderCommand : CommandBase<Unit>
    {
        public Guid CustomerId { get; }

        public Guid OrderId { get; }

        public string Currency { get; }

        public List<ProductDto> Products { get; }

        public ChangeCustomerOrderCommand(
            Guid customerId,
            Guid orderId,
            List<ProductDto> products,
            string currency)
        {
            this.CustomerId = customerId;
            this.OrderId = orderId;
            this.Currency = currency;
            this.Products = products;
        }
    }
}