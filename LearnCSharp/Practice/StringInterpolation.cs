namespace LearnCSharp.Practice
{
    static class StringInterpolation
    {
        public static void InterpolationMethod()
        {
            /**
             * Interpolation - allows us to insert variables into a string literal
             *                 precede a string literal with $
             *                 {} are placeholders
             */

            // Without Interpolation...
            string firstname = "Sabari";
            string lastname = "Vivek";
            double experience = 4.5;
            
            string concat_1 = firstname + " " + lastname + " " + experience;
            string concat_2 = $"{firstname} {lastname} {experience}";

            Console.WriteLine(concat_1);
            Console.WriteLine(concat_2);
        }
    }
}
