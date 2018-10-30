using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;
using ConsoleApp1.CarRental.Office.Interfaces;

namespace ConsoleApp1.CarRental.Office
{
    public abstract class CarRentalOfficeBase : ICarRentalOffice
    {
        public abstract List<IVehicle<IEngine, IGearbox, ICarFeatures>> Cars { get; set; }

        public virtual List<IVehicle<IEngine, IGearbox, ICarFeatures>> AvailableCars(IRentalOptions options)
        {
            DateTime startDate = options.StartDate;
            DateTime endDate = startDate.AddDays(options.RentalIntarval);

            List < IVehicle<IEngine, IGearbox, ICarFeatures> > result = new List<IVehicle<IEngine, IGearbox, ICarFeatures>>();

            foreach (var car in Cars)
            {
                // todo check date
                if (car.IsRent)
                    continue;

                IVehicle<IEngine, IGearbox, ICarFeatures> availablecar 
                    = car.Rentals.Where(c => c.Options.StartDate <= startDate || c.Options.StartDate.AddDays(c.Options.RentalIntarval) >= endDate).Select(c => c.Car).Single();

                result.Add(availablecar);
            }

            return result;
        }
    }
}