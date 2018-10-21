using ConsoleApp1.CarRental.Interfaces;

namespace ConsoleApp1.CarRental
{
    public abstract class Vehicle : IVehicle
    {
        public IRental Rent(IRentalOptions options)
        {
            double totalPrice = options.Price * options.RentalIntarval;

            //client.CreditCardNumber(totalPrice);

            return default(IRental);
        }

        public abstract int YearOfRegistration { get; set; }
        public abstract int Milleage { get; set; }
        public abstract double HorsePower { get; set; }
    }
}