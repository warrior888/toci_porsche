using System.Collections.Generic;
using ConsoleApp1.CarRental.Interfaces.Geography;

namespace ConsoleApp1.Geography.Interfaces
{
    public interface IRentalLocation: IGeographicsLocation

    {
        List<IGeographicsLocation> Children { get; set; }
        long Id { get; set; } 
    }
}