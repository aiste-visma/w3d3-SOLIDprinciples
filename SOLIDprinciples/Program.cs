using SOLIDprinciples.Contracts;
using SOLIDprinciples.BusinessLogic;

//private IPaymentProcessor _paymentProcessor;
//private IOrderRepository _persistOrder;
//private ISendEmail _sendEmail;
//private IValidateOrder _validateOrder;


ILogger logger = new ConsoleLogger();
IOrderRepository repository = new FileOrderRepository();
ISendEmail notification = new Notification(logger);
IValidateOrder validator = new OrderValidation();

//IPaymentProcessor paymentPayPal = new PayPalPayment(logger);
IPaymentProcessor payment = new CreditCardPayment(logger);

OrderService orderService = new OrderService(
    payment, repository, notification, validator);

Order order = new Order
{
    Id = 1,
    Total = 350,
    PaymentMethod = "PayPal",
    CustomerEmail = "customer@email.com"
};

orderService.ProcessOrder(order);


Console.WriteLine("Hello, World!");
