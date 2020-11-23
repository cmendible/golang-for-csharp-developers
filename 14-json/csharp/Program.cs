using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("json in C#");

            // dictionary with student grades
            var grades = new Dictionary<string, int> { { "math", 5 }, { "chemistry", 5 } };

            // serialize the dictionary to json string
            var jsonString = JsonConvert.SerializeObject(grades);

            // print the json string
            Console.WriteLine(jsonString);

            // deserialize the json string back to a dictionary
            grades = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonString);

            // print the math score
            Console.WriteLine(grades["math"]);
        }
    }

}
