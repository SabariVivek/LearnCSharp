namespace LearnCSharp.Practice
{
    public class Constructor
    {
        /**
         * Construtor is a special type of method is used to initialize the value for class variables...
         * Constructor name should be same as class name...
         * Constructor should not have any return type...
         * Constructor won't return anything...
         * It will be automatically call when an object is created for a class which is having the constructor...
         * We can have multiple constructors in a class...
         * But, the constructors should have different parameters...
         * Static class cannot have constructors...
         */
        public Constructor()
        {
            Console.WriteLine("I am the default constructor...");
        }

        public Constructor(string name)
        {
            Console.WriteLine("I am the parameterized constructor with the name : " + name);
        }

        public Constructor(int age)
        {
            Console.WriteLine("I am the parameterized constructor with the age : " + age);
        }

        public Constructor(String name, int age)
        {
            Console.WriteLine("I am the parameterized constructor with the name : \"" + name + "\" and age : \"" + age + "\"");
        }

        public static void ConstructorMethod()
        {
            Constructor construct_1 = new Constructor();
            Constructor construct_2 = new Constructor("Sabari Vivek");
            Constructor construct_3 = new Constructor(24);
            Constructor construct_4 = new Constructor("Sabari Vivek", 24);
        }
    }
}
