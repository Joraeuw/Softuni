using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double yearlyP = double.Parse(Console.ReadLine());

            Console.WriteLine(dep + term * (dep * yearlyP / 1200));
        }
    }
}
