using System.Collections.Generic;

namespace ConsoleApp1.Insurance.Interfaces
{
    public interface IInsurance
    {
        double Price { get; set; }

        IInsuranceAccident TypeOfAccident { get; set; }

        IInsuranceAccident InsuranceAccident { get; set; }

    }
}