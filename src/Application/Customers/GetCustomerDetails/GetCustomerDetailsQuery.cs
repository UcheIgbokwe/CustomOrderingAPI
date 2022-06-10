using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Queries;

namespace Application.Customers.GetCustomerDetails
{
    public class GetCustomerDetailsQuery : IQuery<CustomerDetailsDto>
    {
        public GetCustomerDetailsQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        public Guid CustomerId { get; }
    }
}