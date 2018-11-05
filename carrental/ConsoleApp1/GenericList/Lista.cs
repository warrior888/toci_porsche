using System.Collections.Generic;
using ConsoleApp1.CarRental;
using ConsoleApp1.CarRental.Interfaces;

namespace ConsoleApp1.GenericList
{
    public class Lista
    {
        List<int> wiek=new List<int>(); //lista liczb całkowitych
        List<IClient> klienci=new List<IClient>();
        Client Andrzej=new Client();
        Client Michal = new Client();
        Client Dawid = new Client();
        Client Bartek = new Client();
        public void DodajKlienta()
        {
            klienci.Add(new Client() {Email = "mmm@ss.pl",});
            klienci.Add(Michal);
            klienci.Add(Dawid);
            klienci.Add(Bartek);

        }
        //typy proste
        //float, double - zmienno przecinkowe
        //int liczby calkowite 
        //string  - ciagi znaków
        //char pojedynczy znak
        //bool -true false
        //swój typ czyli Klasa
        //np nasza klasa klient
        public bool zapiywaniepliku()
        {
            ///wykonuja sie jakies operacja
            /// 
            bool stan = false;
            return stan;
        }
        //void nic nie zwraca
        public void DodajWiek() //public -widoczne wszędzie protected - widoczne w klasach dziedziczących private widoczne tylko w ciele danej klasy ( wyjątek wzorzec kompozycja *ciekawostka)
        {
            wiek.Add(9);
            wiek.Add(12);
            wiek.Add(15);
            wiek.Add(20);
 
        }

        public void DodajWiek(int zmiennaPrzechowujacaWiek)
        {
            this.wiek.Add(zmiennaPrzechowujacaWiek);
        }

        public List<int> osobyStarszeNiz15() //metoda ktora zwraca liste intów
        {
            List<int> osobyStarsze=new List<int>(); //tymczasowa lista do ktorej dodamy osoby starsze badz majace 15 lat
            foreach (int item in wiek)//petla która przechodzi po liscie wiek i odwoluje sie do pojedynczych elementów czyli 9,12,15,20,20
            {
                if (item >= 15) // warunek sprawdzajacy czy pojedynczy element listy wiek jest wiekszy badz rowny 15
                {
                    osobyStarsze.Add(item); // dodanie do tymczasowej listy wieku który jest wiekszy badz rowny 15
                }
            }

            return osobyStarsze; //zwrocenie listy generycznej
        }
        public int zwrocWiek()
        {
             return wiek[2];
        }
        //ogolnie wszystko powinnismy pisac po ang:)
    }
}