using System;
using System.IO;

namespace Disposing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dispose in C#");

            // use using to dispose resources
            using (var sw = new StreamWriter("test.txt"))
            {
                sw.WriteLine("some data...");
            }
        }
    }
}
