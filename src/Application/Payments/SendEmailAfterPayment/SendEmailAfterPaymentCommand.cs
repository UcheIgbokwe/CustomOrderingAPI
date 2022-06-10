using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;
using Domain.Payments;
using MediatR;
using Newtonsoft.Json;

namespace Application.Payments.SendEmailAfterPayment
{
    public class SendEmailAfterPaymentCommand : InternalCommandBase<Unit>
    {
        public PaymentId PaymentId { get; }

        [JsonConstructor]
        public SendEmailAfterPaymentCommand(Guid id, PaymentId paymentId) : base(id)
        {
            this.PaymentId = paymentId;
        }
    }
}