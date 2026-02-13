using SOLIDprinciples.Contracts;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderService
    {
        private readonly IPaymentStrategy _paymentProcessor;
        private readonly IOrderRepository _persistOrder;
        private readonly ILogger _logger;
        private ISendEmail _sendEmail;
        private IValidateOrder _validateOrder;

        public OrderService(
            IPaymentStrategy paymentProcessor, 
            IOrderRepository orderPersistence, 
            ILogger logger,
            ISendEmail sendEmail,
            IValidateOrder validateOrder)
        {
            _paymentProcessor = paymentProcessor;
            _persistOrder = orderPersistence;
            _logger = logger;
            _sendEmail = sendEmail;
            _validateOrder = validateOrder;
        }

        public void ProcessOrder(Order order)
        {
            _validateOrder.ValidateOrder(order);
            _paymentProcessor.ProcessPayment(order);
            _persistOrder.SaveOrder(order);
            _sendEmail.Notify(order);
            _logger.Log("Order processed");
        }
    }

}
