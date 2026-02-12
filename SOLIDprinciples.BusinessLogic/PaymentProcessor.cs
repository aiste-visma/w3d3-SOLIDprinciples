using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public abstract class PaymentProcessor
    {
        public abstract void ProcessPayment(Order order);
    }
}
