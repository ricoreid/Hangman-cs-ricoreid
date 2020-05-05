using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LIFES = 5;
            Lost playerStatus = new Lost(LIFES);
            Capitals capital = new Capitals();
            Hashed hashedWord = new Hashed();
            Win won = new Win();
            Uncover word = new Uncover();
            Inputs inputs = new Inputs();
            Update usedLetters = new Update();
            bool gamePlay = true;

            string countryCapital = capital.getCapital().ToLower();
            string userInput = "*";
            string hashWord = hashedWord.setWordToHash(countryCapital);

            while (gamePlay)
            {
                if (!playerStatus.getStatus())
                {
                    Console.WriteLine("You have lost!\nBetter luck next time :-)");
                    break;
                }
                Console.WriteLine("********** HANGMAN **********");
                Console.WriteLine(word.uncoverWord(hashWord, countryCapital, userInput));
                Console.WriteLine("Life points: {0}", playerStatus.getLifePoints());
                Console.Write("Letters used: ");
                foreach (char letter in usedLetters.getUsedLetters())
                    Console.Write($"{letter} ");
                Console.WriteLine();
                userInput = inputs.getInput();
                hashWord = word.uncoverWord(hashWord, countryCapital, userInput);
                if (won.isWin(hashWord, countryCapital))
                {
                    Console.Clear(); // for the next few lines, please refractor it because you are not DRY!
                    Console.WriteLine("********** HANGMAN **********");
                    Console.WriteLine(word.uncoverWord(hashWord, countryCapital, userInput));
                    Console.WriteLine("Life points: {0}", playerStatus.getLifePoints());
                    Console.Write("Letters used: ");
                    foreach (char letter in usedLetters.getUsedLetters())
                        Console.Write($"{letter} ");
                    Console.WriteLine();
                    Console.WriteLine("SUPER!!!.... YOU HAVE WON!\nGOOD JOB! :-)");
                    // play victory music here
                    // put an anime here...
                    break;
                }
                else if (!countryCapital.Contains(userInput))
                {
                    Console.WriteLine("This entry does not exists");
                    playerStatus.updateLifePoints(1);
                }
                Console.Clear();
            }
        }
    }
}
