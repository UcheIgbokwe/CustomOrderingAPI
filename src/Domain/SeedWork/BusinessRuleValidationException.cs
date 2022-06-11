using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.SeedWork
{
    public class BusinessRuleValidationException : Exception
    {
        public IBusinessRulee BrokenRule { get; }

        public string Details { get; }

        public BusinessRuleValidationException(IBusinessRulee brokenRule) : base(brokenRule.Message)
        {
            BrokenRule = brokenRule;
            this.Details = brokenRule.Message;
        }

        public BusinessRuleValidationException() : base()
        {
        }

        protected BusinessRuleValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public BusinessRuleValidationException(string message) : base(message)
        {
        }

        public BusinessRuleValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override string ToString()
        {
            return $"{BrokenRule.GetType().FullName}: {BrokenRule.Message}";
        }
    }
}