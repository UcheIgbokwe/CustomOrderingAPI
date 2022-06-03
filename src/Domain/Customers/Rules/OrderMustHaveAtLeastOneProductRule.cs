using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Customers.Orders;
using Domain.SeedWork;

namespace Domain.Customers.Rules
{
    public class OrderMustHaveAtLeastOneProductRule : IBusinessRulee
    {
        private readonly List<OrderProductData> _orderProductData;

        public OrderMustHaveAtLeastOneProductRule(List<OrderProductData> orderProductData)
        {
            _orderProductData = orderProductData;
        }

        public bool IsBroken() => _orderProductData.Count == 0;

        public string Message => "Order must have at least one product";
    }
}