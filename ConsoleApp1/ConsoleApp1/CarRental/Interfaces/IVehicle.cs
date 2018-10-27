using ConsoleApp1.CarRental.Interfaces.CarOptions;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IVehicle
    {
        IRental Rent(IRentalOptions options);

        int YearOfRegistration { get; set; }

        int Milleage { get; set; }

        IEngine Engine { get; set; }

        IGearbox Gearbox { get; set; }
    }
}