using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class CreditCardPayment : IPaymentProcessor
    {
        private ILogger _logger;
        public CreditCardPayment(ILogger logger) 
        { 
            _logger = logger;
        }
        public void ProcessPayment(Order order)
        {
            _logger.Log("Paid with credit card");
        }
    }
}
