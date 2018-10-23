using ConsoleApp1.Insurance.Interfaces;

namespace ConsoleApp1.Insurance
{
    public abstract class Insurance : IInsurance
    {
        public double Price { get; set; }
        public IInsuranceAccident TypeOfAccident { get; set; }
        public IInsuranceAccident InsuranceAccident { get; set; }
    }
}