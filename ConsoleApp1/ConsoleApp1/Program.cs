using System;
using System.Collections.Generic;
using ConsoleApp1.CarRental.CarRentalGallery;
using ConsoleApp1.CarRental.Cars;
using ConsoleApp1.CarRental.Engines;
using ConsoleApp1.CarRental.Interfaces;
using ConsoleApp1.CarRental.Interfaces.CarOptions;
using ConsoleApp1.Dal.Attributes;
using ConsoleApp1.Dal.PostgreSql;
using ConsoleApp1.GenericList;
using ConsoleApp1.Insurance;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IVehicle<IEngine, IGearbox, ICarFeatures> auto = new Car();

            IVehicle<IEngine, IGearbox, ICarFeatures> auto = new Car<IOilEngine, IGearbox, ICarFeatures>();
            //auto.CarFeatures.Mark
            int dzielna = 5;


            string powitanie = "Witam  was drodzy porszakowcy";

            char znaczek = 'c';

            double dzielnik = 4.5;

            bool prawdaczyfalsz = false;

            double wynik = dzielna / dzielnik; // ==

            // + - * / = == && || ^ ? ? | ! & | < > <= >= () [] {} . ++ -- ,

            // 2 + 2 * 2 = 6

            int xor = 5 ^ 2;


            bool logicznyprzyklad = 7 > 9 && 8 < 9; // flase true


            //Dictionary<string, IVehicle<string, string> > djafkds = new Dictionary<string, IVehicle<string, string>>();
            //Dictionary<string, IGearbox> fbdfd = new Dictionary<string, IGearbox>();

            int zwrotka;
            List<int> osobyStarszeLista = new List<int>(); //tworzymy liste intów ktora bedzie przechowywac wynik metody z Klasy Lista osobyStarszeNiz15() - metoda zwraca liste intów
            //dlatego mozemy sobie przypisac do innej listy (typy sie zgadzaja)

            Lista wiek=new Lista();
            wiek.DodajWiek();
            wiek.DodajWiek(20);
            zwrotka=wiek.zwrocWiek();

            osobyStarszeLista = wiek.osobyStarszeNiz15();

            Console.WriteLine("Liczba zwracaba :{0} stan zapisywania: {1}",zwrotka, wiek.zapiywaniepliku());
            Console.WriteLine("{0}", wiek.zwrocWiek());

            foreach (var osoba in osobyStarszeLista)
            {
                Console.WriteLine("Osoba starsza : {0}",osoba);
            }

            ////petle i tablice
            /// 

            Console.WriteLine(wynik);
           //string wpisuzytkownika = Console.ReadLine();


            string[] listaprogramistowtociporsche = { "andrzej", "czarli", "damsterius", "g4cester", "Igor", "Grzegorz", "Damian", "GR" };
            double[] place = new double[listaprogramistowtociporsche.Length];

            int iloscuczestnikow = listaprogramistowtociporsche.Length;

            foreach (string czlonek in listaprogramistowtociporsche)
            {
                Console.WriteLine(czlonek);
            }

            
            for (int i = 0, j = listaprogramistowtociporsche.Length; i < listaprogramistowtociporsche.Length; i++, j--)
            {
                place[i] = 3500;

                    /////
            }



            string ddl = "create table Developers (" +


                         "id serial primary key," +
                         "name text" +
                         "); ";

            string[] pieces = ddl.Split(' ');

            string classofentity = "public class " + pieces[2] + " { } ";

            using (PostgreSqlDbAccess access = new PostgreSqlDbAccess("User ID=postgres;Password=beatka;Host=localhost;Port=5432;Database=porsche; "))
            {
                foreach (string dev in listaprogramistowtociporsche)
                {
                    access.Insert(new Developers { name = dev });
                }
                
            }

//            ICarGallery<int, string, double> test ; //= new 

            InsuranceSuperCover isc = new InsuranceSuperCover();
            
        }
    }

    public class Developers : IEntity
    {
        [SqlInsertIgnore]
        public int id { get; set; } //5

        public string name { get; set; }
    }


}
