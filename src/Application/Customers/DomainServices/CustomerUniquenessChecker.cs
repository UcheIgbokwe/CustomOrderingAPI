using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Data;
using Dapper;
using Domain.Customers;

namespace Application.Customers.DomainServices
{
    public class CustomerUniquenessChecker : ICustomerUniquenessChecker
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public CustomerUniquenessChecker(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public bool IsUnique(string customerEmail)
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();

            const string sql = "SELECT TOP 1 1" +
                               "FROM [orders].[Customers] AS [Customer] " +
                               "WHERE [Customer].[Email] = @Email";
            var customersNumber = connection.QuerySingleOrDefault<int?>(sql,
                            new
                            {
                                Email = customerEmail
                            });

            return !customersNumber.HasValue;
        }
    }
}