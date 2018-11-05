using ConsoleApp1.CarRental.Interfaces.Geography;

namespace ConsoleApp1.Geography
{
    public class GeographicRegion  :IGeographicsLocation
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Height { get; set; }
    }
}