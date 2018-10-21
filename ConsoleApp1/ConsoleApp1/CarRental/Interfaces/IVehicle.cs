namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IVehicle
    {
        IRental Rent(IRentalOptions options);

        int YearOfRegistration { get; set; }

        int Milleage { get; set; }

        double HorsePower { get; set; }
    }
}