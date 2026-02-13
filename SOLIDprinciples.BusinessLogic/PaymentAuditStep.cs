using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentAuditStep : IPaymentStep
    {
        private ILogger _logger;

        public PaymentAuditStep(ILogger logger)
        {
            _logger = logger;
        }

        public async Task Handle(decimal amount, Func<Task> next)
        {
            _logger.Log($"Payment auditing. Logged amount: {amount}.");

            await next();
        }
    }
}
