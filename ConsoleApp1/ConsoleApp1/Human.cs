using System;

namespace ConsoleApp1
{
    public abstract class Human
    {
        public abstract int Sex();

        public abstract string Name();

        public virtual bool peselvalidate(string pesel)
        {
            string year = pesel.Substring(0, 2);
            string month = pesel.Substring(2, 2);
            string day = pesel.Substring(4, 2);

            int intYear = Convert.ToInt32(year);
            int intMonth = Convert.ToInt32(month);
            int intDay = Convert.ToInt32(day);

            if (intYear >= 0 && intYear <= 99)
            {

            }



            return true;
        }

        //public abstract bool validate(string name);

        public bool validate()
        {

            int lenghth = Name().Length;

            if ('a' == Name()[lenghth - 1])
            {
                return true;
            }


            return false;
        }
    }
}