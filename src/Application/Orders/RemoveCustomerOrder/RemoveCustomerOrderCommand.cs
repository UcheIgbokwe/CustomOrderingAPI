using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;

namespace Application.Orders.RemoveCustomerOrder
{
    public class RemoveCustomerOrderCommand : CommandBase
    {
        public Guid CustomerId { get; }

        public Guid OrderId { get; }

        public RemoveCustomerOrderCommand(Guid customerId,Guid orderId)
        {
            this.CustomerId = customerId;
            this.OrderId = orderId;
        }
    }
}