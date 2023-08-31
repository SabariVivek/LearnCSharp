namespace LearnCSharp.Practice
{
    public class Abstract
    {
        /**
         * Abstract modifier is used to indicate the components/implementations are incomplete...
         * We can use the abstract modifier for Class & Methods...
         * We cannot apply it for Variables...
         * If the class inherits the abstract class, unimplemented methods in abstract class should be implemented in inherited class...
         * We cannot create an object for abstract class...
         */
        public static void AbstractMethod()
        {
            Boat boat = new Boat();
            Lorry lorry = new Lorry();
            Bike bike = new Bike();

            // Vehicle vehicle = new Vehicle(); // Cannot create object...

            boat.VehicleMethod();
            lorry.VehicleMethod();
            bike.VehicleMethod();
        }
    }

    abstract class Vehicle
    {
        public abstract void VehicleMethod();
    }

    class Boat : Vehicle
    {
        public override void VehicleMethod()
        {
            Console.WriteLine("Boat has no wheels");
        }
    }

    class Lorry : Vehicle
    {
        public override void VehicleMethod()
        {
            Console.WriteLine("Lorry wheel count : " + 8);
        }
    }

    class Bike : Vehicle
    {
        public override void VehicleMethod()
        {
            Console.WriteLine("Bike wheel count : " + 2);
        }
    }
}
