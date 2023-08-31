namespace LearnCSharp.Practice
{
    static class TypeCasting
    {
        /**
         * Type Casting : Converting a value to a differenct data type...
         */
        public static void TypeCastingMethod()
        {
            // Coverting double to int...
            double value = 24.53;
            int newValue = Convert.ToInt32(value);
            Console.WriteLine(newValue + " | " + newValue.GetType()); // More than .5 new value would be taken in int...

            // Converting string to int...
            string age = "23";
            int newAge = Convert.ToInt32(age);
            Console.WriteLine(newAge + " | " + newAge.GetType());

            // Converting int to String...
            int lived = 93;
            string livedYears = Convert.ToString(lived);
            Console.WriteLine(livedYears + " | " + livedYears.GetType());

            // Converting int to double...
            int withouDecimal = 29;
            double withDecimal = Convert.ToDouble(withouDecimal);
            withDecimal = withDecimal + 0.1; // We have to add decimal value to converted one...
            Console.WriteLine(withDecimal + " | " + withDecimal.GetType());
        }
    }
}
