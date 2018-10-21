using ConsoleApp1.CarRental.Interfaces;

namespace ConsoleApp1.CarRental.Cars.CarModels
{
    public class R8 : Audi
    {
        public override int YearOfRegistration { get; set; }
        public override int Milleage { get; set; }
        public override double HorsePower { get; set; }
    }
}