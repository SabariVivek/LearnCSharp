namespace LearnCSharp.Practice
{
    static class Variables
    {
        public static void VariableMethod()
        {
            int x;       // Declaration...
            x = 10;      // Initialization...
            int y = 10;  // Declaration + Initialization...
            Console.WriteLine("The value of x and y are " + x + ", " + y);

            // Types of variable...
            int age = 24;
            string name = "Sabari Vivek";
            char symbol = '@';
            double height = 172.8;
            bool minor = false;
            var anyValue = 21.8; // Using var, we can store any value like Object in Java...

            Console.WriteLine(age + " | " + name + " | " + symbol + " | " + height + " | " + minor + " | " + anyValue);
        }
    }
}
