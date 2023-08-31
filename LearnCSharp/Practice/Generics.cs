namespace LearnCSharp.Practice
{
    internal class Generics
    {
        /**
         * Generic -- Not specific to a particular data type...
         *            Allows <T> to classes, methods, fields etc.,
         *            Allows for code reusability for different data types...
         *            <T> we can put anytext inside that, no need of putting 'T'...
         */
        public static void GenericMethod()
        {
            String[] fruits = { "Apple", "Mango", "Grapes", "Banana", "Watermelon" };
            int[] ages = { 21, 45, 67, 32, 30 };
            double[] height = { 172.5, 168.9, 155.2, 174.2, 180 };

            PrintElements(fruits);
            PrintElements(ages);
            PrintElements(height);
        }

        public static void PrintElements<Thing>(Thing[] any)
        {
            foreach (Thing emp in any)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("--------------");
        }
    }
}
