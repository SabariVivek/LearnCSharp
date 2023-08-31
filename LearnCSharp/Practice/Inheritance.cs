namespace LearnCSharp.Practice
{
    class Inheritance : Bus
    {
        /**
         * Inheritance is the concept the acquiring the properties of the another class...
         * 
         * Representations : 
         *      * Parent - Child
         *      * SubClass - SuperClass 
         *      * SuperClass - BaseClass
         */

        public static void InheritanceMethod()
        {
            Inheritance inherit = new Inheritance();
            Console.WriteLine("Bus Company : " + inherit.busName);
            Console.WriteLine("Door Count  : " + inherit.doorCount);
            Console.WriteLine("Wheel Count : " + inherit.wheelCount);
            Console.WriteLine("Top Speed   : " + inherit.topSpeed);
        }
    }

    class Bus : Wheel
    {
        // By default, the below one is private...
        protected string busName = "Volvo";
    }

    class Wheel : Door
    {
        // By default, the below one is private...
        protected int wheelCount = 8;
    }

    class Door : Speed
    {
        // By default, the below one is private...
        protected int doorCount = 2;
    }

    class Speed
    {
        // By default, the below one is private...
        protected int topSpeed = 250;
    }
}
