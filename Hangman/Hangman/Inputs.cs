/*
    Reads a user input until it contains only letter

    Returns:
    str: The validated input
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Inputs
    {
        private string userInput = null;
        Update letters = new Update();

        public string getInput()
        {
            Console.WriteLine("Please enter a letter or, \nYou may try and guess the capital:");
            userInput = Console.ReadLine();

            while (userInput.Any(char.IsDigit) || userInput.Contains('$') || userInput.Any(char.IsPunctuation) || userInput.Contains('^') || userInput.Equals(" ")) // doesn't work for the '$'
            {
                Console.WriteLine("Invalid Input \nPlease try again:");
                userInput = Console.ReadLine();
            }

            Console.WriteLine(userInput.Length);

            if (userInput.Length == 1)
            {
                Console.WriteLine("adding letter to list");
                letters.setUsedLetters(char.Parse(userInput));
            }
             
            return userInput;
        }
    }
}

