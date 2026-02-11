namespace SOLIDprinciples.Contracts
{
    public interface IPaymentProcessor
    {
        public void ProcessPayment(Order order);
    }
}
