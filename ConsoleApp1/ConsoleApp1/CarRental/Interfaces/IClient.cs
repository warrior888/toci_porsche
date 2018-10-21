using System;
using ConsoleApp1.CarRental.Interfaces.CreditCards;

namespace ConsoleApp1.CarRental.Interfaces
{
    public interface IClient
    {
        string Name { get; set; }
        string SurName { get; set; }
        string Pesel { get; set; }
        ICreditCard CreditCard { get; set; }

    }
}