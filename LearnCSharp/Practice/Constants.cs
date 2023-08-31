namespace LearnCSharp.Practice
{
    static class Constants
    {
        /*
         * Constant : Immutable value which we cannot change at runtime...
         * "const" keyowrd is used to create a constant value in C# like final in Java...
         * Good to declare it with capital letter for better readability..
         */
        public static void ConstantMethod()
        {
            const double PI = 3.141;

            // Trying to redeclare...
            // PI = 3.15;

            Console.WriteLine(PI);
        }
    }
}
