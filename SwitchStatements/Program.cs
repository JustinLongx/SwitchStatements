using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "C#";

            Console.WriteLine("What is your favorite subject, C# or history?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "history":
                    Console.WriteLine("History is fun");
                    break;
                default:
                    break;
            }
        }
    }
}
