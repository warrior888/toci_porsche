using System.Collections.Generic;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;

namespace ConsoleApp1.CarRental
{
    public abstract class Vehicle<TEngine, TGearbox, TCarFeatures> : IVehicle<IEngine, IGearbox, ICarFeatures>
        where TEngine : IEngine
        where TGearbox : IGearbox
        where TCarFeatures : ICarFeatures 
    {
        public IRental Rent(IRentalOptions options)
        {
            double totalPrice = options.Price * options.RentalIntarval;


            //client.CreditCardNumber(totalPrice);

            return default(IRental);
        }

        public abstract List<IRental> Rentals { get; set; }

        public abstract int YearOfRegistration { get; set; }
        public abstract int Milleage { get; set; }
        public abstract IEngine Engine { get; set; }
        public abstract IGearbox Gearbox { get; set; }
        public abstract ICarFeatures CarFeatures { get; set; }
        public abstract bool IsRent { get; set; }
    }
}