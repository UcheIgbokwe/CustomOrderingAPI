using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Customers.Orders;
using Domain.SeedWork;

namespace Domain.Payments
{
    public class PaymentCreatedEvent : DomainEventBase
    {
        public PaymentCreatedEvent(PaymentId paymentId, OrderId orderId)
        {
            this.PaymentId = paymentId;
            this.OrderId = orderId;
        }

        public PaymentId PaymentId { get; }

        public OrderId OrderId { get; }
    }
}