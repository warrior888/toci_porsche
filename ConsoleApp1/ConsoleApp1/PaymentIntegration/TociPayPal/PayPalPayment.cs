using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CreditCards;
using ConsoleApp1.PaymentIntegration.Interfaces;
using PayPal.Api;

namespace ConsoleApp1.PaymentIntegration.TociPayPal
{
    public class PayPalPayment : Payment, IPayPalPayment
    {
        public IPaymentResponse Pay(ICreditCard card, IRental rental)
        {
            Transaction transaction = new Transaction();

            //transaction.amount
 //           transaction.payee
            //transaction.payment_options.

            return default(IPaymentResponse);
        }
    }
}