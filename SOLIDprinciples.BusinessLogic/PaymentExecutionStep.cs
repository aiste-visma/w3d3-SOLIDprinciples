using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentExecutionStep : IPaymentStep
    {
        private ILogger _logger;

        public PaymentExecutionStep(ILogger logger)
        {
            _logger = logger;
        }

        public async Task Handle(decimal amount, Func<Task> next)
        {
            _logger.Log($"Executing payment of {amount} amount");

            await next();
        }
    }
}
