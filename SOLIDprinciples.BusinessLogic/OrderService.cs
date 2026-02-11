namespace SOLIDprinciples.BusinessLogic
{
    public class OrderService
    {
        private OrderValidation _validation = new OrderValidation();
        private PaymentProcessing _processing = new PaymentProcessing();
        private Notification _notification = new Notification();
        private OrderPersistence _persistence = new OrderPersistence();
        public void ProcessOrder(Order order)
        {
            _validation.ValidateOrder(order);
            _processing.ProccessPayment(order);
            _notification.Notify(order);
            _persistence.PersistOrder(order);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public string? CustomerEmail { get; set; }
    }



}
