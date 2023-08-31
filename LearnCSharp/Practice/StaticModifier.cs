namespace LearnCSharp.Practice
{
    public static class StaticModifier
    {
        /**
         * It is a modifier, used to declare a static member which belong to the class itself, rather that to a specific object...
         * Methods can automatically called by using class name instead of creating an object for it...
         */
        public static void StaticMethod()
        {
            Car.CarSpeedAndCarModel(); // Calling the static method directly using the class name...
            Car.CarSpeedAndCarModel(); // Calling the static method directly using the class name...
            Car.CarSpeedAndCarModel(); // Calling the static method directly using the class name...
        }
    }

    class Car
    {
        int carModelYear;
        static int carSpeed;

        public Car()
        {
            this.carModelYear = 2019;
            carSpeed++;
        }

        public static void CarSpeedAndCarModel()
        {
            Car car = new Car();
            Console.WriteLine("Card Speed : " + carSpeed); // Static object can we directly called inside class...
            Console.WriteLine("Card Model : " + car.carModelYear);
        }
    }
}
