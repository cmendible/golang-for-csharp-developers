using System;

namespace SwithStatement
{
    class Program
    {
        static void getGenerationName(int yearOfBirth)
        {
            switch (yearOfBirth)
            {
                case var year when year > 1997:
                    Console.WriteLine("Post Millenials");
                    break;
                case var year when year > 1981 && year <= 1996:
                    Console.WriteLine("Millenials");
                    break;
                case var year when year > 1965 && year <= 1980:
                    Console.WriteLine("Generation X");
                    break;
                case var year when year > 1946 && year <= 1964:
                    Console.WriteLine("Baby Boomers");
                    break;
                default:
                    Console.WriteLine("Silent generation");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Switch in C#");

            getGenerationName(1975);
        }
    }
}
