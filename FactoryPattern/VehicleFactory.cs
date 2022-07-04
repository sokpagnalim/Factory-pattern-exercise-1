using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTire)
        {
            switch(numberOfTire)
            {
                case 2:
                    return new Motorcycle();
                    case 4:
                    return new Car();
                default:
                    return new Car();

           }
        }
    }
}
