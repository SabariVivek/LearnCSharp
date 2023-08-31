namespace LearnCSharp.Practice
{
    static class ExceptionHandling
    {
        public static void ExceptionHandlingMethod()
        {
            /**
             * Exception -- Error that occurs during runtime of the program...
             * 
             * try - set of code where occurs the exception... 
             * catch - what has to be done when exception caught...
             * finally - always executed irrespective of the exception caught or not...
             * 
             * RULES :
             *      1. try without catch is not possible...
             *      2. multiple catch block is possible...
             */

            try
            {
                int a = 10, b = 0;
                int c = a / b;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the Try and Catch Block...");
            }
        }
    }
}
