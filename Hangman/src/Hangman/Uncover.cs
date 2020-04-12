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
        string hashedWord;
        string actualWord;
        string toUncover;

        public Uncover() { }
        public Uncover( string hashedWord, string actualWord, string toUncover )
        {
            this.hashedWord = hashedWord;
            this.actualWord = actualWord;
            this.toUncover = toUncover;
            uncoverWord(hashedWord, actualWord, toUncover);
        }

        public string uncoverWord( string hashedWord, string actualWord, string toUncover = "*" )
        {

            if( actualWord == toUncover )
            {
                return toUncover;
            }
            else
            {
                for ( int i = 0; i < actualWord.Length; i++ )
                {
                    if ( actualWord.ElementAt( i ) == char.Parse( toUncover ) )
                    {
                        char[] word = hashedWord.ToCharArray();
                        word[i] = Char.Parse(toUncover);
                        hashedWord = string.Join("", word);
                    }
                }

                return hashedWord;
            }
        }
    }
}
