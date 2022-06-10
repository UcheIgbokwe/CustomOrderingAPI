using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;
using Domain.Customers;
using Domain.Customers.Orders;
using Domain.SeedWork;

namespace Application.Customers.RegisterCustomer
{
    public class RegisterCustomerCommandHandler : ICommandHandler<RegisterCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerUniquenessChecker _customerUniquenessChecker;
        private readonly IUnitOfWork _unitOfWork;
        public RegisterCustomerCommandHandler(ICustomerRepository customerRepository, ICustomerUniquenessChecker customerUniquenessChecker, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerUniquenessChecker = customerUniquenessChecker;
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDto> Handle(RegisterCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = Customer.CreateRegistered(request.Email, request.Name, _customerUniquenessChecker);
            await _customerRepository.AddAsync(customer);
            await _unitOfWork.CommitAsync(cancellationToken);

            return new CustomerDto { Id = customer.Id.Value };
        }
    }
}