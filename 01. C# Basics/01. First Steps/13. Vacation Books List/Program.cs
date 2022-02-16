using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerH = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine((double)pages / (double)pagesPerH / days);
        }
    }
}
