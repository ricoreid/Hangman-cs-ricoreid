/*
    Checks if life points is equal 0

    Args:
    int: The life life_points

    Returns:
    bool: True if life point is equal 0, False otherwise
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman
{
    public class Lost
    {
        private int lifePoints;

        public Lost(int lifePoints)
        {
            this.lifePoints = lifePoints;
        }

        public bool getStatus()
        {
            if(lifePoints == 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void updateLifePoints(int points)
        {
            lifePoints = lifePoints - points;
        }

        public void setLifePoints(int points)
        {
            lifePoints = points;
        }

        public void addLifePoints(int points)
        {
            lifePoints = lifePoints + points;
        }

        public int getLifePoints()
        {
            return lifePoints;
        }
    }
}
