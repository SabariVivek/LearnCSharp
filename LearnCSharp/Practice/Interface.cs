namespace LearnCSharp.Practice
{
    public class Interface
    {
        /**
         * Inheritance -- Defines a "contract" that all the classes inheriting from should follow...
         * 
         * ** An Interface declares "what a class should have"...
         * ** An inheriting class defines "how it should do it"...
         * ** Benefit = Security + can achieve Multiple Inheritance...
         * 
         */
        public static void InterfaceMethod()
        {
            Banks bank = new Banks();
            bank.Kotak();
            bank.HDFC();
            bank.Canara();
            bank.Swiss();
        }
    }

    interface BanksInIndia
    {
        void Kotak();
        void HDFC();
        void Canara();
    }

    interface BanksInJapan
    {
        void Swiss();
    }

    class Banks : BanksInIndia, BanksInJapan
    {
        public void Canara()
        {
            Console.WriteLine("Canara Bank");
        }

        public void HDFC()
        {
            Console.WriteLine("HDFC Bank");
        }

        public void Kotak()
        {
            Console.WriteLine("Kotak Bank");
        }

        public void Swiss()
        {
            Console.WriteLine("Swiss Bank");
        }
    }
}
