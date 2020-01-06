using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ConsoleApp2";

            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var number = rnd.Next(1, 7);
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
