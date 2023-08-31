namespace LearnCSharp.Practice
{
    public class Methods
    {
        // Method -- It is a block of statements, executed when it gets called...
        public static void Method()
        {
            Methods method = new Methods();
            method.PrintMethod("Sabari", "Automation Tester", "Chennai");
            method.PrintMethod("Vivek", "Developer", "Banglore");
            method.PrintMethod("Rocky", "DBA", "Singapore");
            method.PrintMethod("Prabhu", "SQL Developer", "Manglore");
            method.PrintMethod("Harry", "Automation Engineer", "Malysia");

            // Return Methods...
            Console.WriteLine(method.ReturnMethod());
            Console.WriteLine(method.ReturnMethod());
            Console.WriteLine(method.ReturnMethod());
            Console.WriteLine(method.ReturnMethod());
            Console.WriteLine(method.ReturnMethod());

            // Overloaded Methods...
            Console.WriteLine(method.ReturnMethod(1, 10));
            Console.WriteLine(method.ReturnMethod(1, 20));
            Console.WriteLine(method.ReturnMethod(1, 30));
            Console.WriteLine(method.ReturnMethod(1, 40));
            Console.WriteLine(method.ReturnMethod(1, 50));
        }

        public void PrintMethod(string name, string designation, string location)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("My name is " + name + "...");
            Console.WriteLine("I am working as a " + designation + "...");
            Console.WriteLine("I am living in " + location + "...");
            Console.WriteLine("------------------------------------------");
        }

        public int ReturnMethod()
        {
            Random random = new Random();
            return random.Next(1, 100);
        } 
        
        // Overloaded method...
        public int ReturnMethod(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);
        }
    }
}
