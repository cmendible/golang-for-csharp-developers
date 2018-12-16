using System;

namespace pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pointers in C#");

            unsafe // <AllowUnsafeBlocks>true</AllowUnsafeBlocks> se in the project file
            {
                var count = 231418;

                int* pointer = &count;
                Console.WriteLine(*pointer); // 231418

                // set value of count through pointer
                *pointer = 0;
                Console.WriteLine(count);
            }
        }
    }
}
