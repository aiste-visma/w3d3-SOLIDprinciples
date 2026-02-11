using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentProcessing
    {
        public void ProccessPayment(Order order)
        {
            if (order.PaymentMethod == "CreditCard")
            {
                Console.WriteLine("Paid with credit card");
            }
            else if (order.PaymentMethod == "PayPal")
            {
                Console.WriteLine("Paid with PayPal");
            }
            else
            {
                throw new Exception("Unknown payment method");
            }
        }
    }
}
