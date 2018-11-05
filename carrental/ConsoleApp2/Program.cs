//using Toci.CarRental.Gallery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dummy NowaDummy = 
            long pesel = 84080818074; // int long
            long wyliczenie = pesel - 2; // 84080818072

            // + - = * / > < <= >= || && | & ^ ++ --

            int pierwsza = 3;
            int druga = 4;

            int wynik = pierwsza * druga;

            Console.WriteLine(wynik);

            if (wynik > 13) // 12 > 13 false
            {
                Console.WriteLine("czarli");
                
            }
            else // true
            {
                Console.WriteLine("Toci");
            }
                                       //0      1         2              3
            string[] herositoci = {"Czarli", "Marcin", "Bartek", "Andrzej"};

            Console.WriteLine(herositoci[0]);

            foreach (string element in herositoci)
            {
                Console.WriteLine(element + " lol foreach");
            }

            for (int i = 0; i < herositoci.Length; i++)
            {
                Console.WriteLine(herositoci[i]);
            }

            Console.ReadLine();
        }
    }
}
