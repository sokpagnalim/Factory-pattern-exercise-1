using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
            
        }
    }
}
