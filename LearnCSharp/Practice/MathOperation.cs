namespace LearnCSharp.Practice
{
    static class MathOperation
    {
        public static void MathOperationMethod()
        {
            double x = 3.99, y = 5;

            double power = Math.Pow(x, 2);
            double sqrt = Math.Sqrt(x);
            double abs = Math.Abs(x);
            double round = Math.Round(x);
            double ceil = Math.Ceiling(x);
            double floor = Math.Floor(x);
            double max = Math.Max(x, y);
            double min = Math.Min(x, y);

            Console.WriteLine(power + " | " + sqrt + " | " + abs + " | " + round + " | " + ceil + " | " + floor + " | " + max + " | " + min);
        }
    }
}