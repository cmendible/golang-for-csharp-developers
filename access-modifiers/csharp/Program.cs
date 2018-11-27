using System;

namespace AccessModifiers
{
    public class Student
    {
        // Private variable
        private string password;

        // Public variable
        public string Email;

        public Student(string email, string password)
        {
            this.password = password;
            this.Email = email;
        }

        // Private Function
        private string InternalPassword()
        {
            return password;
        }

        // Public Function
        public string GetPassword()
        {
            return this.InternalPassword();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers in C#");

            var student = new Student("username@student.io", "password");
            Console.WriteLine($"email: {student.Email}");
            Console.WriteLine($"password: {student.GetPassword()}");
        }
    }
}
