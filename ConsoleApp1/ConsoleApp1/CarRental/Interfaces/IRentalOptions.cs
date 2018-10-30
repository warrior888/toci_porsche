using System;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IRentalOptions
    {
        double KilometerLimit { get; set; }

        double Price { get; set; }

        int RentalIntarval { get; set; } // 1 2 3 4 5 6 7 8 9 10  - 999999999999999999999999999999999999999999999999999

        IClient Client { get; set; }

        DateTime StartDate { get; set; }
    }
}