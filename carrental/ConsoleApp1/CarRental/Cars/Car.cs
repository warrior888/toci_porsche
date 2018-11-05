using System.Collections.Generic;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;

namespace ConsoleApp1.CarRental.Cars
{
    public class Car<TEngine, TGearbox, TCarFeatures> : Vehicle<TEngine, TGearbox, TCarFeatures>
        where TEngine : IEngine
        where TGearbox : IGearbox
        where TCarFeatures : ICarFeatures
    {
        public override List<IRental> Rentals { get; set; }
        public override int YearOfRegistration { get; set; }
        public override int Milleage { get; set; }
        public override IEngine Engine { get; set; }
        public override IGearbox Gearbox { get; set; }
        public override ICarFeatures CarFeatures { get; set; }
        public override bool IsRent { get; set; }
    }
}