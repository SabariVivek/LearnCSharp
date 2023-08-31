namespace LearnCSharp.Practice
{
    static class Loops
    {
        public static void LoopMethods()
        {
            // For Loop...
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // For each loop...
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Mango");
            list.Add("Grapes");
            list.Add("Jack Fruit");
            list.Add("Pineapple");

            foreach (string temp in list)
            {
                Console.WriteLine(temp);
            }

            // While loop...
            int k = 1;
            while (k <= 10)
            {
                Console.WriteLine(k);
                k++;
            }

            // Do while loop...
            int j = 2;
            do
            {
                Console.WriteLine(j);
            } while (j != 2);
        }
    }
}
