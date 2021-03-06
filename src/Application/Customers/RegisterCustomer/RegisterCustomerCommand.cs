using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;

namespace Application.Customers.RegisterCustomer
{
    public class RegisterCustomerCommand : CommandBase<CustomerDto>
    {
        public string Email { get; }

        public string Name { get; }

        public RegisterCustomerCommand(string email, string name)
        {
            this.Email = email;
            this.Name = name;
        }
    }
}