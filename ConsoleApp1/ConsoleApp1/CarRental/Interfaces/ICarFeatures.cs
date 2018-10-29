namespace ConsoleApp1.CarRental.Interfaces
{
    public interface ICarFeatures
    {
        string Mark { get; set; }
        string Model { get; set; }
        bool Naviagtion { get; set; }
        bool CruiseControl { get; set; }
    }
}