namespace ConsoleApp1.CarRental.Interfaces.CarOptions
{
    public interface IEngine
    {
        IFuel Fuel { get; set; }
        IGearbox Gearbox { get; set; }
        double HorsePower { get; set; }
    }
}