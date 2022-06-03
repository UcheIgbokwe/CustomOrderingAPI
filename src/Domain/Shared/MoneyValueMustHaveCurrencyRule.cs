using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Domain.Shared
{
    public class MoneyValueMustHaveCurrencyRule : IBusinessRulee
    {
        private readonly string _currency;

        public MoneyValueMustHaveCurrencyRule(string currency)
        {
            _currency = currency;
        }

        public bool IsBroken() => string.IsNullOrEmpty(_currency);

        public string Message => "Money value must have currency";
    }
}