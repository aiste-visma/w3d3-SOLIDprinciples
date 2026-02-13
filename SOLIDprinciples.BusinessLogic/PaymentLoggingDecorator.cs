using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentLoggingDecorator : IPaymentStrategy
    {
        IPaymentStrategy _strategy;
        ILogger _logger;

        public PaymentLoggingDecorator(IPaymentStrategy strategy, ILogger logger)
        {
            _strategy = strategy;
            _logger = logger;
        }
        public void ProcessPayment(Order order)
        {
            _strategy.ProcessPayment(order);
            if (AppSettings.Instance().EnablePaymentLogging == true)
                _logger.Log($"Paid {order.Total} with {order.PaymentMethod}");
        }
    }
}
