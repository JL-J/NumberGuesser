using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "JLJ";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor(); 


            
        }
    }
}
