using System;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;
using ConsoleApp1.CarRental.Interfaces.Geography;

namespace ConsoleApp1.CarRental
{
    public class Rental : IRental
    {
        public IRentalOptions Options { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IGeographicsLocation VehicleRetrivalLocation { get; set; }
        public IGeographicsLocation VehicleReturnLocation { get; set; }
        public IVehicle<IEngine, IGearbox, ICarFeatures> Car { get; set; }
    }
}