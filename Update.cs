/*
    Appends the letter to used_letters if it doesn't occur

    Args:
    list: The list of already used letters
    str: The letter to append

    Returns:
    list: The updated list of already used letters
*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    public class Update
    {
        private char newLetter;
        private IList<char> usedLetters = new List<char>(){'a', 'b', 'c'};

        public Update(){}
        public Update( char newLetter )
        {
            this.newLetter = newLetter;
        }

        public IList<char> getUsedLetters()
        {
            Console.WriteLine(usedLetters.ToString());
            return usedLetters;
        }

        public void setUsedLetters(char newLetter)
        {
            foreach( char letter in usedLetters )
            {
                if( letter == newLetter )
                {
                    Console.WriteLine("The letter \'{0}\' has been used already");
                    break;
                }
                usedLetters.Add(newLetter);
            }
        }



    } // end class Update
} // end namespace Hangman