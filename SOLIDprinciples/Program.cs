using SOLIDprinciples.Contracts;
using SOLIDprinciples.BusinessLogic;

//AppSettings.Instance().EnablePaymentLogging = false;

ILogger logger = new ConsoleLogger();
IOrderRepository repository = new FileOrderRepository();
ISendEmail notification = new Notification(logger);
IValidateOrder validator = new OrderValidation();

//IPaymentStrategy paymentPayPal = new PayPalPayment(logger);
IPaymentStrategy payment = new CreditCardPayment(logger);

PaymentTimingDecorator timingDecorator = new PaymentTimingDecorator(payment, logger);
PaymentLoggingDecorator loggingDecorator = new PaymentLoggingDecorator(timingDecorator, logger);

OrderService orderService = new OrderService(
    loggingDecorator, repository, logger, notification, validator);

Order order = new Order
{
    Id = 1,
    Total = 350,
    PaymentMethod = "PayPal",
    CustomerEmail = "customer@email.com"
};

orderService.ProcessOrder(order);


Console.WriteLine("Hello, World!");
