using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberies = double.Parse(Console.ReadLine());
            double bannanasKG = double.Parse(Console.ReadLine());
            double orangesKG = double.Parse(Console.ReadLine());
            double raspberriesKG = double.Parse(Console.ReadLine());
            double strawberiesKG = double.Parse(Console.ReadLine());

            double sum = (raspberriesKG * (strawberies / 2)) +
                (orangesKG * (strawberies / 2 - (strawberies / 2) * 0.4)) +
                (bannanasKG * (strawberies / 2 - (strawberies / 2) * 0.8)) +
                (strawberiesKG * strawberies);

            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
