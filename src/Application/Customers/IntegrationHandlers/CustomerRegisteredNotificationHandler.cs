using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Configuration.Processing;
using MediatR;

namespace Application.Customers.IntegrationHandlers
{
    public class CustomerRegisteredNotificationHandler : INotificationHandler<CustomerRegisteredNotification>
    {
        private readonly ICommandsScheduler _commandsScheduler;

        public CustomerRegisteredNotificationHandler(
            ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler = commandsScheduler;
        }

        public async Task Handle(CustomerRegisteredNotification notification, CancellationToken cancellationToken)
        {
            // Send welcome e-mail message...
            await this._commandsScheduler.EnqueueAsync(new MarkCustomerAsWelcomedCommand(Guid.NewGuid(),notification.CustomerId));
        }
    }
}