using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(rad * 180 / Math.PI));
        }
    }
}
