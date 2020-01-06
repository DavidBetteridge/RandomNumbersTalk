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
                var rnd = new Random();
                var number = rnd.Next();
                Console.WriteLine(number);
            }
        }
    }
}
