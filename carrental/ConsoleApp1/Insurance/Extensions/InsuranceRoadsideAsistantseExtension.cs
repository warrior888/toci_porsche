using ConsoleApp1.Insurance.Interfaces;

namespace ConsoleApp1.Insurance.Extensions
{
    public static class InsuranceRoadsideAsistantseExtension 
    {
        public static IInsurance RoadSideAsistanceInsurance(this IInsuranceAccidentPlus insuranceAccidentPlus, IInsurance insurance)
        {
            return insurance;
        }
    }
}