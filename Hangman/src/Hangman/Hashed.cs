/*
    Generates a password based on the word with dashes instead of letters
    Keeps whitespaces undashed.

    Args:
    str: The word to hash

    Returns:
    str: The hashed password
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Hashed
    {
        private char[] wordToHash = null;
        private string hashedWord = null;
        public Hashed() { }

        public string getWord()
        {
            return hashedWord;
        }

        public string setWordToHash(string word)
        {
            wordToHash = word.ToCharArray();

            for (int i = 0; i < wordToHash.Length; i++ )
            {
                if (wordToHash[i].ToString() != " ")
                {
                    wordToHash[i] = '_';
                }
            }

            return hashedWord = string.Join("", wordToHash);
        }


    }
}
