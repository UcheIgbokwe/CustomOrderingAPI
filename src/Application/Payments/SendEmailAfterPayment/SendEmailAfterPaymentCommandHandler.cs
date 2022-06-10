using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Commands;
using Application.Configuration.Emails;
using Domain.Payments;
using MediatR;

namespace Application.Payments.SendEmailAfterPayment
{
    public class SendEmailAfterPaymentCommandHandler : ICommandHandler<SendEmailAfterPaymentCommand, Unit>
    {
        private readonly IEmailSender _emailSender;
        private readonly IPaymentRepository _paymentRepository;

        public SendEmailAfterPaymentCommandHandler(IEmailSender emailSender, IPaymentRepository paymentRepository)
        {
            _emailSender = emailSender;
            _paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(SendEmailAfterPaymentCommand request, CancellationToken cancellationToken)
        {
            var emailMessage = new EmailMessage("from@email.com", "to@email.com", "content");
            await _emailSender.SendEmailAsync(emailMessage);

            var payment = await this._paymentRepository.GetByIdAsync(request.PaymentId);
            payment.MarkEmailNotificationIsSent();

            return Unit.Value;
        }
    }
}