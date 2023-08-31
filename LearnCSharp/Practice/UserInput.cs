namespace LearnCSharp.Practice
{
    static class UserInput
    {
        public static void UserInputMethod()
        {
            Console.WriteLine("Enter your name : ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " : " + age);
        }
    }
}
