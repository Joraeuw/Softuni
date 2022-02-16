using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            Console.WriteLine(rent + (rent * 0.2) + (rent * 0.2 - rent * 0.2 * 0.45) + (rent / 3));
        }
    }
}
