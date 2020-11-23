using System;

namespace Disposing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("errors in C#");

            var numbers = new int[] { -1, 5 };
            foreach (var num in numbers)
            {
                try
                {
                    var inc = Increment(num);
                    Console.WriteLine($"Incremented Number: {inc}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed Number: {num}, error message: {ex.Message}");
                }
            }
        }

        private static int Increment(int n)
        {
            if (n < 0)
            {
                throw new Exception("math: cannot process negative number");
            }
            return n + 1;
        }
    }
}
