namespace ConsoleApp1.CarRental.Interfaces.CreditCards
{
    public interface IPayment
    {
        IPaymentResponse Pay(ICreditCard card, IRental rental);
    }
}