namespace ConsoleApp1
{
    public class Women: Man
    {
        protected int plec;
        protected string name;
        public Women()
        {
            plec = 2;
            name = "Agata";
        }

        public Women(string Name)
        {
            name = Name;
            plec = 2;
        }


        public override int Sex()
        {
            return plec;
        }

        public override string Name()
        {
            return name;
        }


        
    }
}