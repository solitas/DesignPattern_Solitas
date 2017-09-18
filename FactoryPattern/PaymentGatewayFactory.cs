namespace DesignPattern
{
    public class PaymnentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(PaymentMethod method, Product product)
        {
            IPaymentGateway gateway = null;
            switch (method)
            {
                case PaymentMethod.BANK_ONE: 
                    gateway = new BankOne();
                    break;
                case PaymentMethod.BANK_TWO:
                    gateway = new BankTwo();
                    break;
                case PaymentMethod.BEST_FOR_ME:
                    if (product.Price < 50) {
                        gateway = new BankTwo();
                    }
                    else
                    {
                        gateway = new BankOne();
                    }
                    break;
            }
            return gateway;
        }

    }
}