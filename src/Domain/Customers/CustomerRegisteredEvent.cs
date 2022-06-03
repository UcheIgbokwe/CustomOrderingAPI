using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Customers
{
    public class CustomerRegisteredEvent : DomainEventBase
    {
        public CustomerId CustomerId { get; }

        public CustomerRegisteredEvent(CustomerId customerId)
        {
            this.CustomerId = customerId;
        }
    }
}