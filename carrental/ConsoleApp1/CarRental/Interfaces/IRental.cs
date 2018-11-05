using System;
using ConsoleApp1.CarRental.Interfaces.CarOptions;
using ConsoleApp1.CarRental.Interfaces.Geography;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IRental
    {
        IRentalOptions Options { get; set; }

        IGeographicsLocation VehicleRetrivalLocation { get; set; }

        IGeographicsLocation VehicleReturnLocation { get; set; }

        IVehicle<IEngine, IGearbox, ICarFeatures> Car { get; set; }
    }
}