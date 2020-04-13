using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int LIFES = 5;
            Lost playerStatus = new Lost(LIFES);
            Capitals capital = new Capitals();
            Hashed hashedWord = new Hashed();
            Win won = new Win();
            Uncover word = new Uncover();
            Inputs inputs = new Inputs();
            Update usedLetters = new Update();

            string countryCapital = capital.getCapital();
            string userInput = "*";
            string hashWord = hashedWord.setWordToHash(countryCapital);

            while (playerStatus.getStatus())
            {
                Console.WriteLine("********** HANGMAN **********");
                Console.WriteLine( word.uncoverWord(hashWord, countryCapital, userInput));
                Console.WriteLine("Life points: {0}", playerStatus.getLifePoints());
                Console.Write("Letters used: ");
                foreach (char letter in usedLetters.getUsedLetters().ToString())
                    Console.Write(letter);
                Console.WriteLine();
                userInput = inputs.getInput();
                if(countryCapital.Contains(userInput))
                {
                    hashWord = word.uncoverWord(hashWord, countryCapital, userInput);
                }
                else
                {
                    Console.WriteLine("Invalid letter");
                    playerStatus.updateLifePoints(1);
                }
                Console.Clear();
            }

        }
    }
}
