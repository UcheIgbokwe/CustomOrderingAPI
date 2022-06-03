using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Customers.Rules
{
    public class CustomerEmailMustBeUniqueRule : IBusinessRulee
    {
        private readonly ICustomerUniquenessChecker _customerUniquenessChecker;

        private readonly string _email;

        public CustomerEmailMustBeUniqueRule(ICustomerUniquenessChecker customerUniquenessChecker, string email)
        {
            _customerUniquenessChecker = customerUniquenessChecker;
            _email = email;
        }

        public bool IsBroken() => !_customerUniquenessChecker.IsUnique(_email);

        public string Message => "Customer with this email already exists.";
    }
}