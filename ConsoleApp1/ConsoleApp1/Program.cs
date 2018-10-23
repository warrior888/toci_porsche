using System;
using ConsoleApp1.CarRental.CarRentalGallery;
using ConsoleApp1.Dal.Attributes;
using ConsoleApp1.Dal.PostgreSql;
using ConsoleApp1.Insurance;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
