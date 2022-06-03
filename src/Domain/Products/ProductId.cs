using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Products
{
    public class ProductId : TypedIdValueBase
    {
        public ProductId(Guid value) : base(value)
        {
        }
    }
}