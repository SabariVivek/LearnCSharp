using System;
using System.ComponentModel;
using System.Reflection;

namespace LearnCSharp.Practice
{
    internal class Enum
    {
        /**
         * enums - Special method which contains a set of named integer constants...
         *         We can use enums when you have values that will not change...
         *         To get the integer value from the item, you must explicitly convert to an int...
         */
        public static void EnumMethod()
        {
            Console.WriteLine("I am working in : " + Browsers.CHROME);
            Console.WriteLine("I am working in : " + Browsers.EDGE);
            Console.WriteLine("I am working in : " + Browsers.FIREFOX);
            Console.WriteLine("I am working in : " + Browsers.SAFARI);
        }
    }
    enum Browsers
    {
        CHROME,
        EDGE,
        FIREFOX,
        SAFARI
    }
}
