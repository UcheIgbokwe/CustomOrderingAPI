using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Customers.Orders;
using Domain.SeedWork;

namespace Domain.Payments
{
    public class Payment : Entity, IAggregateRoot
    {
        public PaymentId Id { get; private set; }

        private OrderId _orderId;

        private DateTime _createDate;

        private PaymentStatus _status;

        private bool _emailNotificationIsSent;

        private Payment()
        {
        }

        public Payment(OrderId orderId)
        {
            this.Id = new PaymentId(Guid.NewGuid());
            this._createDate = DateTime.UtcNow;
            this._orderId = orderId;
            this._status = PaymentStatus.ToPay;
            this._emailNotificationIsSent = false;

            this.AddDomainEvent(new PaymentCreatedEvent(this.Id, this._orderId));
        }

        public void MarkEmailNotificationIsSent()
        {
            this._emailNotificationIsSent = true;
        }
    }
}