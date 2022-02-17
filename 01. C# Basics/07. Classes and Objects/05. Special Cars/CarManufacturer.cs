using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            do
            {
                var currentTirePair = new Tire[4];
                line = Console.ReadLine();
                if (line == "No more tires") break;


                string[] data = line.Split(' ');

                currentTirePair[0] = new Tire(int.Parse(data[0]), double.Parse(data[1]));
                currentTirePair[1] = new Tire(int.Parse(data[2]), double.Parse(data[3]));
                currentTirePair[2] = new Tire(int.Parse(data[4]), double.Parse(data[5]));
                currentTirePair[3] = new Tire(int.Parse(data[6]), double.Parse(data[7]));
                tires.Add(currentTirePair);
            } while (true);

            do
            {
                line = Console.ReadLine();
                if (line == "Engines done") break;

                string[] data = line.Split(' ');

                engines.Add(new Engine(int.Parse(data[0]), double.Parse(data[1])));
            } while (true);

            do
            {
                line = Console.ReadLine();
                if (line == "Show special") break;

                string[] data = line.Split(' ');
                cars.Add(new Car(data[0], data[1], int.Parse(data[2]),
                                double.Parse(data[3]), double.Parse(data[4]),
                                engines[int.Parse(data[5])], tires[int.Parse(data[6])]));
            } while (true);

            var specialCars = new List<Car>();
            foreach (var car in cars)
            {
                double pressure = 0;
                foreach (var tire in car.Tires)
                {
                    pressure += tire.Pressure;
                }
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && pressure >= 9 && pressure <= 10)
                {
                    specialCars.Add(car);
                    car.Drive(2);
                }
            }

            foreach (var spCar in specialCars)
            {
                Console.WriteLine(spCar.WhoAmI());
            }
        }
    }
}
