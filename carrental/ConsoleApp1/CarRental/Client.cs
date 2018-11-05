using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CreditCards;

namespace ConsoleApp1.CarRental
{
    public class Client :IClient
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Pesel { get; set; }
       // public ICreditCard CreditCard { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }
        public string TelephoneType { get; set; }
        public bool JoinToTociPreferred { get; set; }
    }
}