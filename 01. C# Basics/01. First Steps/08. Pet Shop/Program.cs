using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherCount = int.Parse(Console.ReadLine());

            Console.WriteLine($"{2.5 * dogsCount + 4 * otherCount} lv.");
        }
    }
}
