namespace LearnCSharp.Practice
{
    internal class HashSet
    {
        public static void HashSetMethod()
        {
            // Declaration..
            HashSet<string> lang = new HashSet<string>();
            lang.Add("C");
            lang.Add("C++");
            lang.Add("C#");
            lang.Add("Java");
            lang.Add("Ruby");

            // Printing the values
            foreach (var val in lang)
            {
                Console.WriteLine(val);
            }
        }
    }
}
