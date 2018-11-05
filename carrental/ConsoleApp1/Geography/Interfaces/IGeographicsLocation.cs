using System.Collections.Generic;

namespace ConsoleApp1.CarRental.Interfaces.Geography
{
    public interface IGeographicsLocation
    {
        double Longitude { get; set; }

        double Latitude { get; set; }

        double Height { get; set; }
    }
}