namespace LearnCSharp.Practice
{
    public class ListClass
    {
        /**
         * List -- It is a data structure that represents the list of objects that can be accessed by Index...
         *         It is similar to array, but can dinamically increase and decrease its size...
         */
        public static void ListMethod()
        {
            // Declaration...
            List<String> fruits = new List<String>();
            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Grapes");
            fruits.Add("Kiwi");
            fruits.Add("Strawberry");

            // Printing using foreach loop...
            foreach (String str in fruits)
            {
                Console.WriteLine(str);
            }

            // Printing using index...
            Console.WriteLine("2nd index value : " + fruits[2]);

            // Remove using value...
            fruits.Remove("Strawberry");
            Console.WriteLine("After removed using value : ");
            PrintList(fruits);

            // Remove using index...
            fruits.RemoveAt(0);
            Console.WriteLine("After removed using index : ");
            PrintList(fruits);

            // Getting size of the list...
            Console.WriteLine("Size of the list : " + fruits.Count);

            // Insert an element using Index...
            fruits.Insert(0, "Sabari - But not a fruit");
            Console.WriteLine("After adding an element using index : ");
            PrintList(fruits);

            // Contains checking...
            Console.WriteLine("Is that available : " + fruits.Contains("Kiwi"));

            // Soring a list...
            fruits.Sort();
            Console.WriteLine("After Sorting : ");
            PrintList(fruits);

            // Soring in a reverse order...
            fruits.Reverse();
            Console.WriteLine("After Reverse Sorting : ");
            PrintList(fruits);

            // Clear all the values...
            /* fruits.Clear();
            Console.WriteLine("After clearing : ");
            PrintList(fruits); */

            // Converting List to Array...
            Console.WriteLine("Printing after converted to Array : ");
            String[] fruitValues = fruits.ToArray();
            foreach (var fruit in fruitValues)
            {
                Console.WriteLine(fruit);
            }

        }
        public static void PrintList(List<String> fruits)
        {
            if (fruits.Count == 0)
            {
                Console.WriteLine("Nothing is there to print!!!");
            }
            else
            {
                foreach (String str in fruits)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
