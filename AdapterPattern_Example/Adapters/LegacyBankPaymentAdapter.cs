using AdapterPattern_Example.Contracts;
using AdapterPattern_Example.Services;

namespace AdapterPattern_Example.Adapters
{
    public class LegacyBankPaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyBankPaymentService legacyBankPaymentService;

        public LegacyBankPaymentAdapter(LegacyBankPaymentService legacyBankPaymentService)
        {
            this.legacyBankPaymentService = legacyBankPaymentService;
        }

        public void Pay(decimal amount)
        {
            legacyBankPaymentService.MakeTransaction(amount);
        }
    }
}
