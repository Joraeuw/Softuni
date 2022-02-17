using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());


            var car1 = new Car();
            var car2 = new Car(make, model, year);
            var car3 = new Car(make, model, year, fuelQuantity, fuelConsumption);
        }
    }
}
