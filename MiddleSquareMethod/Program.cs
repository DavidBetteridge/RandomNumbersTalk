using System;
using System.Collections.Generic;

namespace MiddleSquareMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var seed = 99L;
            var n = 2;

            var seen = new HashSet<long>();

            while (true)
            {
                var rndNumber = Next(n, seed);
                Console.WriteLine(rndNumber);
                
                if (seen.Contains(rndNumber)) break;
        
                seen.Add(rndNumber);
                seed = rndNumber;
            }
        }

        private static long Next(int n, long seed)
        {
            var squared = (seed * seed);
            var padded = squared.ToString().PadLeft(n * 2, '0');
            var middle = padded.Substring(n / 2, n);

            return long.Parse(middle);
        }
    }
}
