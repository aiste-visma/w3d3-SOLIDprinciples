using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PayPalPayment : IPaymentProcessor
    {
        private ILogger _logger;
        public PayPalPayment(ILogger logger) 
        {
            _logger = logger;
        }
        public void ProcessPayment(Order order)
        {
            _logger.Log("Paid with PayPal");
        }
    }
}
