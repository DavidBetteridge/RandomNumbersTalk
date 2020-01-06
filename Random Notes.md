
Show welcome app


Demostrate max range issue

            var rnd = new Random();
            var number = rnd.Next();
            Console.WriteLine(number);


            for (int i = 0; i < 1000; i++)
            {
                var rnd = new Random();
                var number = rnd.Next(1, 2);
                Console.WriteLine(number);
            }


            -- Dice roll
            for (int i = 0; i < 1000; i++)
            {
                var rnd = new Random();
                var number = rnd.Next(1, 7);
                Console.WriteLine(number);
            }


            --Why it's good for selecting from arrays
            var cards = new string[] { "Ace of clubs", "Two of clubs", "Three of clubs", "Four of clubs" };

            for (int i = 0; i < 1000; i++)
            {
                var rnd = new Random();
                var card = cards[rnd.Next(0, cards.Length)];
                Console.WriteLine(card);
            }



            --Other methods
            var rnd = new Random();

            Console.WriteLine($"Next 1-6 {rnd.Next(1,7)}");

            Console.WriteLine($"NextDouble {rnd.NextDouble()}");

            var buffer = new byte[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            rnd.NextBytes(buffer);
            Console.WriteLine($"NextBytes {string.Join(',', buffer)}");


What can we do with random numbers?
    Well we can calculate PI
    Show visualisation
    Will not be perfect

And we can play games - for example shuffle a pack of cards  (expand if needed)
    Show HigherLower
    What is want another go?  Well you need to shuffle the pack in the same way.
    Seeds

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                var rnd = new Random(12345);
                for (int i = 0; i < 10; i++)
                {
                    var number = rnd.Next(1, 6);
                    Console.WriteLine(number);
                }

                Console.ReadLine();
            }    

        Show seed in game


What happens if we don't specify a seed

    Show both in .net framework and .net core  copy code for console app 2  (hide solution explorer)

        Start both

            Console.Title = "ConsoleApp1";
            for (int i = 0; i < 1000; i++)
            {
                var seed = Environment.TickCount;
                var rnd = new Random(seed);
                var number = rnd.Next(1, 6);
                Console.WriteLine(number);
            }
            Console.ReadLine();

            Change core version
                var seed = Environment.TickCount;
                var r = new Random(seed);
            
            Fix framework version
                var rnd = new Random();
                for (int i = 0; i < 1000; i++)


            https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/Random.cs#L126


How are pseudorandom numbers created?
            MiddleSquareMethod

            The very first software algorithm to generate random numbers, was supposedly written in 1946 by John von Neumann

            To generate a sequence of n-digit pseudorandom numbers, an n-digit starting value is created and squared, producing a 2n-digit number. If the result has fewer than 2n digits, leading zeroes are added to compensate. The middle n digits of the result would be the next number in the sequence, and returned as the result. This process is then repeated to generate more numbers.

            Show demo

            Show graph
                Two issues
                    One - very predictable
                    Two - most seeds converge to zero



Secure?
Cryptographic RNGs (also known as "cryptographically strong" or "cryptographically secure" RNGs) seek to generate random numbers that not only "look random", but are cost-prohibitive to guess. Cryptographic RNGs are RECOMMENDED for applications that use random numbers for information security, such as—


External Sources of Entypry

Measure Randomness