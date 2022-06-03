using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Payments
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByIdAsync(PaymentId id);

        Task AddAsync(Payment payment);
    }
}