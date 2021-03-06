﻿using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            AppHeader();

            GreetUser();

            while (true)
            {

                Random random = new Random();
                int randomNumber = random.Next(1, 11);

                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10.");
                while (guess != randomNumber)
                {
                    string usersGuess = Console.ReadLine();
                    if (!int.TryParse(usersGuess, out guess))
                    {
                        PrintMessage("Sorry, but that's not a number. Please try again.", ConsoleColor.Red); 
                        continue;
                    }
                    guess = Int32.Parse(usersGuess);
                    if (guess != randomNumber)
                    {
                        PrintMessage("Sorry, that's not the number I'm thinking of. Please guess again.", ConsoleColor.Red);
                    }
                }
                PrintMessage("Congrats! You guessed my number!", ConsoleColor.Yellow);

                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        static void AppHeader()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "JLJ";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();

            Console.WriteLine($"Ok {usersName}, let's play a game!");
        }

        static void PrintMessage(string message, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
