using System;
using System.Collections.Generic;
using ConsoleApp1.CarRental.Cars;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;
using ConsoleApp1.Geography;

namespace ConsoleApp1.CarRental.Office
{
    public class CarRentalOffice : CarRentalOfficeBase
    {
        public CarRentalOffice()
        {
            for (int i = 1; i < 10; i++)
            {
                var car = new Car<IEngine, IGearbox, ICarFeatures>()
                {
                    Rentals =
                    {
                        new Rental()
                        {
                            Options = new RentalOptions(), StartDate =
                                new DateTime(2018, i, 01),
                            EndDate = new DateTime(2018, i, 10), VehicleRetrivalLocation = new GeographicRegion(),
                            VehicleReturnLocation = new GeographicRegion()
                        }
                    }
                };

                car.Rentals[0].Car = car;
                
                Cars.Add(car);
            }
          
        }
        public override List<IVehicle<IEngine, IGearbox, ICarFeatures>> Cars { get; set; }
    }
}