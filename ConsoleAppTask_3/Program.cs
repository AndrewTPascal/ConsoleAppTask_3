using System;

namespace ConsoleAppTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your name {0}, your age {1}", Name, Age);
            Console.Write("Enter your birthdate: ");
            var Birth = Console.ReadLine();
            Console.Write("Your birthdate is: " + Birth);
        }
    }

}
