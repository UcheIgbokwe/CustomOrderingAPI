using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Payments
{
    public class PaymentId : TypedIdValueBase
    {
        public PaymentId(Guid value) : base(value)
        {
        }
    }
}