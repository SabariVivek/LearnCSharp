namespace LearnCSharp.Practice
{
    class GetterSetter
    {
        /**
         * Getter & Setter -- Add security to fields by Encapsulation...
         * 
         * Properties : Combine aspects of both fields and methods (share name with a field)...
         * get accessor : Used to return the property value...
         * set accessor : Used to assign a new value...
         * value keyword : Defines a value being assigned by the set (parameter)...
         * 
         * IMPORTANT -- Auto implemented properties (Shortcut for get and set)...
         */
        public static void GetSetMethod()
        {
            VehicleSpeed speed_1 = new VehicleSpeed();
            speed_1.Speed = 124;
            speed_1.Wheel = 6;
            Console.WriteLine("Current Speed : " + speed_1.Speed);
            Console.WriteLine("Total Wheel's : " + speed_1.Wheel);

            VehicleSpeed speed_2 = new VehicleSpeed();
            speed_2.Speed = 199;
            speed_2.Wheel = 4;
            Console.WriteLine("Current Speed : " + speed_2.Speed);
            Console.WriteLine("Total Wheel's : " + speed_2.Wheel);

            VehicleSpeed speed_3 = new VehicleSpeed();
            speed_3.Speed = 246;
            speed_3.Wheel = 2;
            Console.WriteLine("Current Speed : " + speed_3.Speed);
            Console.WriteLine("Total Wheel's : " + speed_3.Wheel);
        }
    }

    class VehicleSpeed
    {
        private int speed;

        public int Speed
        {
            get { return speed; } // Read
            set                   // Write
            {
                if (value > 200)
                {
                    speed = 200;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public int Wheel
        {
            get; set;
        }
    }
}
