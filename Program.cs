using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Update updateList = new Update('c');
            Console.WriteLine($"Hello: {updateList.getUsedLetters()}");
        }
    }
}
