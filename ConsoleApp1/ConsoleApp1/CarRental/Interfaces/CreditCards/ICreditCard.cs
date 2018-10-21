using System;

namespace ConsoleApp1.CarRental.Interfaces.CreditCards
{
    public interface ICreditCard
    {
        string CreditCardNumber { get; set; }
        DateTime CreditCardValidDate { get; set; }
        int Cvv { get; set; }
    }
}