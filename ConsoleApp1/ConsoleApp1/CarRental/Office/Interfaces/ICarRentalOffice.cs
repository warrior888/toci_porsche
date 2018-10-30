using System.Collections.Generic;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;

namespace ConsoleApp1.CarRental.Office.Interfaces
{
    public interface ICarRentalOffice
    {
        List<IVehicle<IEngine, IGearbox, ICarFeatures>> Cars { get; set; }
        List<IVehicle<IEngine, IGearbox, ICarFeatures>> AvailableCars(IRentalOptions options);
    }
}