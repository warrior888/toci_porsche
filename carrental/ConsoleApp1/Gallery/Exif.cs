using ConsoleApp1.CarRental.Interfaces.Geography;
using ConsoleApp1.Gallery.Interfaces;

namespace ConsoleApp1.Gallery
{
    public class Exif : IExif
    {
        public IGeographicsLocation Location { get; set; }
    }
}