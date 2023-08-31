namespace LearnCSharp.Practice
{
    static class ArrayofObjects
    {
        /**
         * We can create an objects using Array...
         */
        public static void ArrayObjectsMethod()
        {
            // Traditional Way...
            House house_1 = new House(21);
            House house_2 = new House(34);
            House house_3 = new House(123);

            house_1.PrintHouseNumber();
            house_2.PrintHouseNumber();
            house_3.PrintHouseNumber();

            // Using Array of Objects Way...
            House[] house = { new House(21), new House(34), new House(123) };
            house[0].PrintHouseNumber();
            house[1].PrintHouseNumber();
            house[2].PrintHouseNumber();
        }
    }

    class House
    {
        int houseNumber;

        public House(int houseNumber)
        {
            this.houseNumber = houseNumber;
        }

        public void PrintHouseNumber()
        {
            Console.WriteLine(houseNumber);
        }
    }
}
