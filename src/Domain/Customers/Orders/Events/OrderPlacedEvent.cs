using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;
using Domain.Shared;

namespace Domain.Customers.Orders.Events
{
    public class OrderPlacedEvent : DomainEventBase
    {
        public OrderId OrderId { get; }

        public CustomerId CustomerId { get; }

        public MoneyValue Value { get; }

        public OrderPlacedEvent(OrderId orderId, CustomerId customerId, MoneyValue value)
        {
            this.OrderId = orderId;
            this.CustomerId = customerId;
            Value = value;
        }
    }
}