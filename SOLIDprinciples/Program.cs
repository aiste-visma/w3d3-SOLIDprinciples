using SOLIDprinciples.Contracts;
using SOLIDprinciples.BusinessLogic;

Order order = new Order
{
    Id = 1,
    Total = 350,
    PaymentMethod = "CreditCard",
    CustomerEmail = "customer@email.com"
};


OrderFacade processOrder = new OrderFacade();

await processOrder.ProcessOrder(order);

Console.WriteLine("Hello, World!");
