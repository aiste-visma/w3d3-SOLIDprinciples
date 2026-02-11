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
        public void ProcessPayment(Order order)
        {
            Console.WriteLine("Paid with PayPal");
        }
    }
}
