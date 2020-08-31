using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if else in C#");

            var value = 1;
            if (value < 0)
            {
                Console.WriteLine($"value is negative");
            }
            else if (value == 0)
            {
                Console.WriteLine($"value is 0");
            }
            else
            {
                Console.WriteLine($"value is postive");
            }
        }
    }
}
