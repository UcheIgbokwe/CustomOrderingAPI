using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;
using Application.Configuration.Data;
using Application.Orders.PlaceCustomerOrder;
using Domain.Customers;
using Domain.Customers.Orders;
using Domain.ForeignExchange;
using Domain.Products;
using MediatR;

namespace Application.Orders.ChangeCustomerOrder
{
    internal sealed class ChangeCustomerOrderCommandHandler : ICommandHandler<ChangeCustomerOrderCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IForeignExchange _foreignExchange;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        internal ChangeCustomerOrderCommandHandler(ICustomerRepository customerRepository, IForeignExchange foreignExchange, ISqlConnectionFactory sqlConnectionFactory)
        {
            _customerRepository = customerRepository;
            _foreignExchange = foreignExchange;
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        public async Task<Unit> Handle(ChangeCustomerOrderCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(new CustomerId(request.CustomerId));

            var orderId = new OrderId(request.OrderId);

            var conversionRates = _foreignExchange.GetConversionRates();
            var orderProducts = request.Products.ConvertAll(x => new OrderProductData(new ProductId(x.Id), x.Quantity));

            var allProductPrices = await ProductPriceProvider.GetAllProductPrices(_sqlConnectionFactory.GetOpenConnection());

            customer.ChangeOrder(orderId,allProductPrices,orderProducts,conversionRates,request.Currency);

            return Unit.Value;
        }
    }
}