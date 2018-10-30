using System.Collections.Generic;
using System.Dynamic;
using ConsoleApp1.CarRental.Interfaces.CarOptions;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IVehicle<TEngine, TGearbox, TCarFeatures>
        where TEngine : IEngine
        where TGearbox : IGearbox
        where TCarFeatures : ICarFeatures
    
    
    {
        IRental Rent(IRentalOptions options);

        List<IRental> Rentals { get; set; }

        int YearOfRegistration { get; set; }

        int Milleage { get; set; }

        TEngine Engine { get; set; }

        TGearbox Gearbox { get; set; }

        TCarFeatures CarFeatures { get; set; }
   
        bool IsRent { get; set; }
    }
}