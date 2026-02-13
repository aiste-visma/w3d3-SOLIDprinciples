using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentTimingDecorator : IPaymentStrategy
    {
        IPaymentStrategy _strategy;
        ILogger _logger;

        public PaymentTimingDecorator(IPaymentStrategy strategy, ILogger logger)
        {
            _strategy = strategy;
            _logger = logger;
        }
        public void ProcessPayment(Order order)
        {
            _strategy.ProcessPayment(order);
            _logger.Log($"Payment made at {DateTime.Now}");
        }
    }
}
