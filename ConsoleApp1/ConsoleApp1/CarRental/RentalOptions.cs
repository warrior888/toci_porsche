using System;
using ConsoleApp1.CarRental.Interfaces;

namespace ConsoleApp1.CarRental
{
    public class RentalOptions : IRentalOptions
    {
        public double KilometerLimit { get; set; }
        public double Price { get; set; }
        public int RentalIntarval { get; set; }
        public IClient Client { get; set; }
        public DateTime StartDate { get; set; }
    }
}