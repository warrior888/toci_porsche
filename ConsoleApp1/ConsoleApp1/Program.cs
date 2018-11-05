using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // tu jest dowolne slowo
            // zmienna
            int liczba = 8; // od uytk, z b d itd
            int dzielnik = 2;

            int wynik = liczba / dzielnik;
            Console.Write(wynik);

            bool trueistrue = true;

            // + - = / * ++ -- && || | & ? ! ?== == ^ < > <= >= 

            string[] programisci = {"bartek", "edek", "viewer"};


            if (wynik < 5) // true false
            {
                Console.Write("Jestem mniejsza od 5");

                foreach (string programista in programisci)
                {
                    Console.WriteLine(programista);
                }



            }

            Human man = new Man();
            Human women = new Women();
            Human Weronika = new Women("Weronika");

            if (Weronika.Sex() == 2 && Weronika.validate())
            {
                Console.WriteLine(Weronika.Name() + "  to kobieta");
            }


            Console.WriteLine(Weronika.Name());

            Console.WriteLine(man.Name());
            Console.WriteLine(women.Name());

            if (man.Name() == "Krzysztof")
            {
                Console.WriteLine("Krzysztof ma na imię Krzysztof");
            }

            if (women.Name() == "Katarzyna")
            {
                Console.WriteLine(women.Name() + " to Katarzyna");
            }

            if (man.Sex() == 1)
            {
                Console.WriteLine(man.Name() + " is a man");
            }
            if (women.Sex() == 2)
            {
                Console.WriteLine(women.Name() + " is a women");
            }

            women.validate();

            if (women.validate())
            {
                Console.WriteLine(women.Name() + " to kobieta zgodnie z walidacją.");
            }


            

            Console.ReadLine();
        }
    }
}
