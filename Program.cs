using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Inputs input = new Inputs();
            Console.WriteLine("Hello {0}", input.getInput());
        }
    }
}
