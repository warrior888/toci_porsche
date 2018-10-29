namespace ConsoleApp1.CarRental.Interfaces.CarOptions
{
    public interface IEngine
    {
        IFuel Fuel { get; set; }
        double HorsePower { get; set; }
    }
}