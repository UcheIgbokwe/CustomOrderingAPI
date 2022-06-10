using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Orders.GetCustomerOrders
{
    public class OrderDto
    {
        public Guid Id { get; set; }

        public decimal Value { get; set; }

        public string Currency { get; set; }

        public bool IsRemoved { get; set; }
    }
}