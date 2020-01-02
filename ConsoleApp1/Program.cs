using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ConsoleApp1";
            for (int i = 0; i < 1000; i++)
            {
                var seed = Environment.TickCount;
                var rnd = new Random(seed);
                var number = rnd.Next(1, 6);
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
