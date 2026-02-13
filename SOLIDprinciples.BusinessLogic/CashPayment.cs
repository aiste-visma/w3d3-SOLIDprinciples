using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    //Violates Liskov Substitution Principle, because the child class doesn't actually 
    //process the payment, but throws an exception
    //
    //public class CashPayment : PaymentProcessor
    //{
    //    public override void ProcessPayment(Order order)
    //    {
    //        throw new NotImplementedException("We don't accept cash");
    //    }
    //}

    //Good implementation, payment is processed

    public class CashPayment : PaymentProcessor
    {
        private ILogger _logger;
        public CashPayment(ILogger logger) 
        {
            _logger = logger;
        }
        public override void ProcessPayment(Order order)
        {
            _logger.Log($"Processing {order.PaymentMethod} payment...");
        }
    }

}
