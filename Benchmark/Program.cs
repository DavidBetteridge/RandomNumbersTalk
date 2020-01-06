using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Security.Cryptography;

namespace RandomTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<RandomTest>();
        }
    }

    public class RandomTest
    {
        [Benchmark]
        public void SystemRandom()
        {
            var rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                var randomNumber = new byte[1];
                rnd.NextBytes(randomNumber);

                Console.WriteLine(randomNumber[0]);
            }
        }

        [Benchmark]
        public void Crypto()
        {
            using var rngCsp = new RNGCryptoServiceProvider();

            for (int i = 0; i < 100; i++)
            {
                var randomNumber = new byte[1];
                rngCsp.GetBytes(randomNumber);

                Console.WriteLine(randomNumber[0]);
            }
        }
    }
}
