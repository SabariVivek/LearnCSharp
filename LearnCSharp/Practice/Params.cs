namespace LearnCSharp.Practice
{
    public class Params
    {
        /**
         * params - A method parameter that takes a variable with number of arguments...
         *          The parameter type must be single dimensional array...
         */
        public static void ParamsMethod()
        {
            Params param = new Params();
            Console.WriteLine(param.AddNumber(10, 20, 30, 40, 50, 60));
            Console.WriteLine(param.AddNumber(10, 20, 30));
            Console.WriteLine(param.AddNumber(50, 60));
        }

        public int AddNumber(params int[] numbers)
        {
            int total = 0;
            
            foreach (int num in numbers)
            {
                total += num;
            }

            return total;
        }
    }
}
