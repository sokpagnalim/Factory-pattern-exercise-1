using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tire does your vehicle have?");
            int userInput = int.Parse(Console.ReadLine());
            IVehicle vehicleTire=VehicleFactory.GetVehicle(userInput);
            vehicleTire.Drive();
        }
    }
}
