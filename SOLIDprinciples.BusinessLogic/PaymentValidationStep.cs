using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    internal class PaymentValidationStep : IPaymentStep
    {
        public async Task Handle(decimal amount, Func<Task> next)
        {
            if (amount <= 0)
            {
                throw new Exception("Invalid amount");
            }
            await next();
        }
    }
}
