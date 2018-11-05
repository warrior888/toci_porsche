using ConsoleApp1.Insurance.Interfaces;

namespace ConsoleApp1.Insurance.Extensions
{
    public static class InsuranceStealExtension 
    {
        public static IInsurance StealInsurance(this IInsuranceAccident stealInsuranceAccident, IInsurance Insurance)
        {
            return Insurance;
        }
    }
}