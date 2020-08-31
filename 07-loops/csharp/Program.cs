using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loops in C#");

            // Normal for loop
            // Count form 0 to 9
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // While like loop
            var total = 1;
            while (total < 1000)
            {
                total += total;

            }
            Console.WriteLine(total);

            // for each loop
            var scores = new Dictionary<string, int> { { "math", 5 }, { "chemestry", 5 } };
            foreach (var kv in scores)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }

            // for each loop with index
            var fruits = new string[] { "apples", "blueberries", "strawberries" };
            var idx = 0;
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"{idx}: {fruit}");
                idx++;
            }

            // Infinite loop
            while (true)
            {
                // do 
            }
        }
    }
}
