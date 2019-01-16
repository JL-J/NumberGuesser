﻿using System;

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

            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();

            Console.WriteLine($"Ok {usersName}, let's play a game!");

            int randomNumber = 7;
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10.");
            while (guess != randomNumber)
            {
                string usersGuess = Console.ReadLine();
                guess = Int32.Parse(usersGuess); 
                if (guess != randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, that's not the number I'm thinking of. Please guess again.");
                    Console.ResetColor();
                }
            }
        }
    }
}
