namespace LearnCSharp.Practice
{
    static class Overriding
    {
        /**
         * Overriding provides a new version of a method inherited from a parent class...
         * Inherited method must be : abstract, virtual, or already overriden...
         * Used with ToString(), Polymorphism...
         * 
         * override keyword is mandatory to indicate the class that you have overrided a method...
         * virtual keyword is mandatory to indicate that the method is availbale for overriding...
         */
        public static void OverridingMethod()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("I am in Animal Class");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("I am in Dog Class");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("I am in Cat Class");
        }
    }
}