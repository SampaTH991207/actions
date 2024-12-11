using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World! This is the app for testing the .NET application.";
            PrintMessage(message);
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}

