/*
    Appends the letter to used_letters if it doesn't occur

    Args:
    list: The list of already used letters
    str: The letter to append

    Returns:
    list: The updated list of already used letters
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Update
    {
        private IList<char> usedLetters = new List<char>();

        public Update() { }
        
        public IList<char> getUsedLetters()
        {
            return usedLetters;
        }

        public void setUsedLetters(char newLetter)
        {
            Console.WriteLine("received letter: {0}", newLetter);
            if(usedLetters.Contains(newLetter))
            {
                Console.WriteLine("The letter \'{0}\' has been used already", newLetter);
            }
            else
            {
                Console.WriteLine("added");
                usedLetters.Add(newLetter);
            }
        }

    }
}
