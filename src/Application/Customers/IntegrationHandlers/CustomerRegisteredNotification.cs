using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.DomainEvents;
using Domain.Customers;

namespace Application.Customers.IntegrationHandlers
{
    public class CustomerRegisteredNotification : DomainNotificationBase<CustomerRegisteredEvent>
    {
        public CustomerId CustomerId { get; }
        public CustomerRegisteredNotification(CustomerRegisteredEvent domainEvent) : base(domainEvent)
        {
            this.CustomerId = domainEvent.CustomerId;
        }

        public CustomerRegisteredNotification(CustomerId customerId) : base(null)
        {
            this.CustomerId = customerId;
        }
    }
}