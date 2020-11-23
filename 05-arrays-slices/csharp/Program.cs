using System;
using System.Collections.Generic;
using System.Linq;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in C#");

            // Array of int
            // Array length must be set a declaration time.
            var series = new int[4] { 1, 2, 5, 7 };
            series.Dump();
            var fruits = new string[3] { "banana", "apple", "pear" };
            fruits.Dump();
            // Slice
            var numbers = new int[4] { 1, 3, 5, 7 };
            numbers = numbers.Append(9).ToArray();
            numbers = numbers.Append(11).ToArray();
            numbers.Dump();

            // Span<T> is the most similar type to Golang's []T.
            var span = numbers.AsSpan();

            // remove first item
            var slice1 = span.Slice(1);
            slice1.Dump();

            // Get first 3 items
            var slice2 = span[0..3];
            slice2.Dump();

            // Get second and third numbers
            var segment = span[2..4];
            segment.Dump();

            // Copy the array to another 
            var newArray = new int[numbers.Length];
            numbers.CopyTo(newArray, 0);
        }
    }

    static class DumpExtensions {
        public static void Dump<T>(this IEnumerable<T> col) {
            Console.Write("[");
            foreach (var t in col) {
                Console.Write($"{t},");
            }
            Console.Write("]\n");
        }

        public static void Dump<T>(this Span<T> col) {
            Console.Write("[");
            foreach (var t in col) {
                Console.Write($"{t},");
            }
            Console.Write("]\n");
        }

    }

}