using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public interface ICustomerUniquenessChecker
    {
        bool IsUnique(string customerEmail);
    }
}