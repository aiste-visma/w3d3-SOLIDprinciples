using SOLIDprinciples.Contracts;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderService
    {
        private readonly IOrderRepository _persistOrder;
        private readonly ILogger _logger;
        private IValidateOrder _validateOrder;
        private OrderEventPublisher _publisher;

        public OrderService(
            IOrderRepository orderPersistence, 
            ILogger logger,
            IValidateOrder validateOrder,
            OrderEventPublisher publisher)
        {
            _persistOrder = orderPersistence;
            _logger = logger;
            _validateOrder = validateOrder;
            _publisher = publisher;
        }

        public void ProcessOrder(Order order, IPaymentStrategy _paymentProcessor)
        {
            _validateOrder.ValidateOrder(order);
            _paymentProcessor.ProcessPayment(order);
            _persistOrder.SaveOrder(order);
            _publisher.Notify(order);
            _logger.Log("Order processed");
        }
    }
}
