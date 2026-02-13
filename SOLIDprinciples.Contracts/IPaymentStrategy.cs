namespace SOLIDprinciples.Contracts
{
    public interface IPaymentStrategy
    {
        public void ProcessPayment(Order order);
    }
}
