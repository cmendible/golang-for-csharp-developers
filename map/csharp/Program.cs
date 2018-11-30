using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary (maps) in C#");

            // dictionary with student grades
            var grades = new Dictionary<string, int> { { "math", 5 }, { "chemestry", 5 } };

            // print the math score
            Console.WriteLine(grades["math"]);

            if (grades.ContainsKey("chemestry"))
            {
                Console.WriteLine(grades["chemestry"]);
            }
        }
    }

}
