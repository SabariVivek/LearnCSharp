namespace LearnCSharp.Practice
{
    static class PolyMorphism
    {
        public static void PlymorphismMethod()
        {
            Asus asus = new Asus();
            HP hp = new HP();
            Dell dell = new Dell();

            Laptop[] laptops = { asus, hp, dell };

            foreach (Laptop laptop in laptops)
            {
                laptop.printLaptopName(); // Performing same action in different types...
            }
        }
    }
    class Laptop
    {
        public virtual void printLaptopName()
        {
            Console.WriteLine("I am the Laptop...");
        }
    }
    class Asus : Laptop
    {
        public override void printLaptopName()
        {
            Console.WriteLine("I am the Asus Laptop...");
        }
    }
    class HP : Laptop
    {
        public override void printLaptopName()
        {
            Console.WriteLine("I am the HP Laptop...");
        }
    }
    class Dell : Laptop
    {
        public override void printLaptopName()
        {
            Console.WriteLine("I am the Dell Laptop...");
        }
    }
}