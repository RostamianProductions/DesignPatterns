namespace AdapterPattern_Example.Contracts
{
    public interface IPaymentProcessor
    {
        void Pay(decimal amount);
    }
}
