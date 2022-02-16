using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaignLength = int.Parse(Console.ReadLine());
            int sweets = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sum = ((cakes * 45) + (waffles * 5.8) + (pancakes * 3.2)) * sweets * campaignLength;

            Console.WriteLine(sum - sum / 8);
        }
    }
}
