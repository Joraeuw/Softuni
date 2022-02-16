using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double relevantPercent = 1 - double.Parse(Console.ReadLine()) * 0.01;


            Console.WriteLine(((l * w * h) * 0.001) * relevantPercent);
        }
    }
}
