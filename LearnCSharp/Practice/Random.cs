namespace LearnCSharp.Practice
{
    static class RandomClass
    {
        public static void RandomMethod()
        {
            Random random = new Random();

            Console.WriteLine(random.Next());       // Any Range...
            Console.WriteLine(random.NextInt64());  // Any Range...

            Console.WriteLine(random.NextDouble()); // Decimal Random...
            Console.WriteLine(random.Next(1, 100)); // Range Random...
        }
    }
}
