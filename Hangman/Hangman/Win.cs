/*
    Checks if the hashed password is fully uncovered

    Args:
    str: The hashed password
    str: The password

    Returns:
    bool
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Win
    {
        private string hashedWord = null;
        private string actualWord = null;

        public Win() { }
        public Win(string hashedWord, string actualWord)
        {
            this.hashedWord = hashedWord;
            this.actualWord = actualWord;
        }



        public bool isWin(string hashedWord, string actualWord)
        {
            if (actualWord.ToLower() == hashedWord.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
