namespace LearnCSharp.Practice
{
    static class ClassAndObjects
    {
        public static void ClassAndObjectMethod()
        {
            SecondClass second = new SecondClass();
            second.Method();
        }
    }

    class SecondClass
    {
        public void Method()
        {
            Console.WriteLine("I am in Second Class...");
        }
    }
}
