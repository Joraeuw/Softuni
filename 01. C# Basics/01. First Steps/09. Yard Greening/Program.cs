using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            Console.WriteLine($"The final price is: {meters * 7.61 - (meters * 7.61 * 0.18)} lv.");
            Console.WriteLine($"The discount is: {meters * 7.61 * 0.18} lv.");
        }
    }
}
