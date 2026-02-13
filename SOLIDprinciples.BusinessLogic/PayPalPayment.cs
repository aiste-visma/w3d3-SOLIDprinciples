using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PayPalPayment : PaymentProcessor, IPaymentStrategy
    {
        private ILogger _logger;
        public PayPalPayment(ILogger logger) 
        {
            _logger = logger;
        }
        public override void ProcessPayment(Order order)
        {
            _logger.Log($"Processing {order.PaymentMethod} payment...");
        }
    }
}
