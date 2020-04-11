/*
    Reads a user input until it contains only letter

    Returns:
    str: The validated input
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class Inputs
    {
        private string userInput;

        public string getInput()
        {
            Console.WriteLine("Please enter a letter or, \nYou may try and get the capital:");
            userInput = Console.ReadLine();

            while(!userInput.Any(char.IsDigit) || userInput.Any(char.IsWhiteSpace) || userInput.Any(char.IsPunctuation)) // doesn't work for the '$'
            {
                Console.WriteLine("Invalid Input \nPlease try again:");
                userInput = Console.ReadLine();
            }

            return userInput;
        }
    } // end class GetInput
} // end namespace Hangman