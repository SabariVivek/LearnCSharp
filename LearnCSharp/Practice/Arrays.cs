namespace LearnCSharp.Practice
{
    public class Arrays
    {
        public static void ArrayMethod()
        {
            Arrays array = new Arrays();
            array.SingleDimensional();
            array.MultiDimensional();
        }

        public void SingleDimensional()
        {
            string[] fruits = { "Apple", "Mango", "Orange", "Banana", "Watermelon" };
            fruits[0] = "Pineapple"; // Value will be replaced in this position...

            foreach (string str in fruits)
            {
                Console.WriteLine(str);
            }

            int[] number = new int[2];
            number[0] = 1;
            number[1] = 2;
            // number[2] = 3; // Exception - ArrayIndexOutOfBoundException...
        }

        public void MultiDimensional()
        {
            // This declaration can be overcome by the below declaration...
            string[] fruits = { "Apple", "Mango", "Grapes", "Pineapple", "Jackfruit" };
            string[] cars = { "Audi", "BMW", "Volvo", "Maruti", "KIA" };
            string[] names = { "Sabari", "Vivek", "Rocky", "Dornal", "Anu" };

            // Declaration...
            string[,] multiArray = {
                { "Apple", "Mango", "Grapes", "Pineapple", "Jackfruit" } ,
                { "Audi", "BMW", "Volvo", "Maruti", "KIA"},
                { "Sabari", "Vivek", "Rocky", "Dornal", "Anu"}
            };

            // Updating the values...
            multiArray[0, 1] = "Kiwi";

            // Printing the values using foreach loop...
            foreach (String str in multiArray)
            {
                Console.WriteLine(str);
            }

            // Printing the values using for loop...
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.Write(multiArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
