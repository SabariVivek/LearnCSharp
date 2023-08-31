namespace LearnCSharp.Practice
{
    static class Strings
    {
        public static void StringMethods()
        {
            string str = " Sabari Vivek ";

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.TrimEnd());
            Console.WriteLine(str.ToCharArray());
            Console.WriteLine(str.Replace(" ", "_"));
            Console.WriteLine(str.Insert(0, "Mr."));
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Substring(1, 4));
            Console.WriteLine(str.Split(" ").Length);
            Console.WriteLine(str.IndexOf("S"));
        }
    }
}
