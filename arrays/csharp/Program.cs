using System;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in C#");

            // Array of int
            // Array lenght must be set a declaration time.
            var series = new int[4] { 1, 2, 5, 7 };

            var fruits = new string[3] { "banana", "apple", "pear" };

            // Slice
            var numbers = new int[4] { 1, 3, 5, 7 };
            numbers.Append(9);
            numbers.Append(11);

            // remove first item
            var slice1 = numbers.Skip(1).ToArray();

            // Get first 3 items
            var slice2 = numbers.Take(3).ToArray();

            // Get second and third numbers
            var segment = new ArraySegment<int>(numbers, 1, 2).ToArray();

            // Copy the array tyo another 
            var newArray = new int[numbers.Length];
            numbers.CopyTo(newArray, 0);
        }
    }
}