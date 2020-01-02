using System;

namespace PackOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var pack = new Pack();

            var rnd = new Random();
            pack.Shuffle(rnd);

            Console.WriteLine(pack.ToString());




            for (int roundNumber = 1; roundNumber <= 100; roundNumber++)
            {
                pack.Shuffle(rnd);
                Console.WriteLine($"Round: {roundNumber}  Score: {pack.HowSuffled()}");
            }
            
            Console.WriteLine(pack.ToString());

            System.IO.File.WriteAllText(@"c:/temp/cards.txt", pack.ToString(), System.Text.Encoding.Default);
        }
    }
}
