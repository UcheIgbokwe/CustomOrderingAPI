using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Customers.Orders.Events
{
    public class OrderChangedEvent : DomainEventBase
    {
        public OrderId OrderId { get; }

        public OrderChangedEvent(OrderId orderId)
        {
            this.OrderId = orderId;
        }
    }
}