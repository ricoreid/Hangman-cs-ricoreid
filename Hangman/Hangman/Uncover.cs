/*
    Uncovers all occurences of the given letter in the hashed password based on the password

    Args:
    str: The hashed password
    str: The password
    str: The letter to uncover

    Returns:
    str: The hashed password with uncovered letter
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Uncover
    {
        public Uncover() { }

        public string uncoverWord(string hashedWord, string actualWord, string toUncover = "*")
        {
            if (toUncover.Length > 1) // if the user tries to solve the word, this checks if it's correct.
            {
                if (actualWord.ToLower() == toUncover.ToLower())
                    hashedWord = toUncover;
                return hashedWord.ToUpper();
            }
            else
            {
                for (int i = 0; i < actualWord.Length; i++)
                {
                    if (actualWord.ToLower().ElementAt(i) == char.Parse(toUncover.ToLower()))
                    {
                        char[] word = hashedWord.ToCharArray();
                        word[i] = Char.Parse(toUncover);
                        hashedWord = string.Join("", word);
                    }
                }

                return hashedWord.ToUpper();
            }
        }
    }
}

