using SOLIDprinciples.Contracts;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderService
    {
        private IPaymentProcessor _paymentProcessor;
        private IOrderRepository _persistOrder;
        private ISendEmail _sendEmail;
        private IValidateOrder _validateOrder;

        public OrderService(
            IPaymentProcessor paymentProcessor, 
            IOrderRepository orderPersistence, 
            ISendEmail sendEmail,
            IValidateOrder validateOrder)
        {
            _paymentProcessor = paymentProcessor;
            _persistOrder = orderPersistence;
            _sendEmail = sendEmail;
            _validateOrder = validateOrder;
        }

        public void ProcessOrder(Order order)
        {
            _validateOrder.ValidateOrder(order);
            _paymentProcessor.ProcessPayment(order);
            _persistOrder.SaveOrder(order);
            _sendEmail.Notify(order);
        }
    }

}
