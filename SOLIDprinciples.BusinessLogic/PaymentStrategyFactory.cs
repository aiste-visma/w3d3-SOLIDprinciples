using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentStrategyFactory : IPaymentStrategyFactory
    {
        IPaymentStrategy _paymentStrategy;
        
        public IPaymentStrategy GetPaymentStrategy(Order order, ILogger _logger)
        {
            if (order.PaymentMethod == "PayPal")
                _paymentStrategy = new PayPalPayment(_logger);
            else if(order.PaymentMethod == "CreditCard")
                _paymentStrategy = new CreditCardPayment(_logger);
            else if( order.PaymentMethod == "Cash")
                _paymentStrategy = new CashPayment(_logger);

                return _paymentStrategy;
        }
    }
}
