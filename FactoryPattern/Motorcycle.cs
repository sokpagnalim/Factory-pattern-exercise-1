﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Motorcycle:IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I'm driving a motorcycle.");
        }
    }
}
