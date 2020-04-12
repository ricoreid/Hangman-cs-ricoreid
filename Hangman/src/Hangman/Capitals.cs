/*
    Picks a random European capital

    Returns:
    str: The name of European capital
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Capitals
    {
        Random random = new Random();
        private string capital;
        private Dictionary<string, string> capitals = new Dictionary<string, string>()
        {
            { "Albania", "Tirana" },
            { "Andorra", "Andorra la Vella" },
            { "Armenia", "Yerevan" },
            { "Austria", "Vienna" },
            { "Azerbaijan", "Baku" },
            { "Belarus", "Minsk" },
            { "Belgium", "Brussels" },
            { "Bosnia and Herzegovina", "Sarajevo" },
            { "Bulgaria", "Sofia" },
            { "Croatia", "Zagreb" },
            { "Cyprus", "Nicosia" },
            { "Czechia", "Prague" },
        };

        public string getCapital()
        {
            int index = random.Next(capitals.Count);
            capital = capitals.ElementAt(index).Value.ToString();

            return capital;
        }
    }
}
