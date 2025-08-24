namespace AdapterPattern_Example.Services
{
    public class LegacyBankPaymentService
    {
        public void MakeTransaction(decimal amount)
        {
            Console.WriteLine($"LegacyBankPayment: Transaction of {amount} Completed.");
        }
    }
}
