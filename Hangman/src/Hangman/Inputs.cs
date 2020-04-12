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
        private string userInput;
        Update letters = new Update();

        public string getInput()
        {
            Console.WriteLine("Please enter a letter or, \nYou may try and get the capital:");
            userInput = Console.ReadLine();

            while (userInput.Any(char.IsDigit) || userInput.Any(char.IsWhiteSpace) || userInput.Any(char.IsPunctuation)) // doesn't work for the '$'
            {
                Console.WriteLine("Invalid Input \nPlease try again:");
                letters.setUsedLetters(char.Parse(userInput));
                userInput = Console.ReadLine();
            }


            return userInput;
        }
    }
}
