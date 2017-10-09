using System;
using System.Collections.Generic;

namespace Task1
{
    class Cup
    {
        private List<Die> die = new List<Die>();

        public void AddDice(Die dice)
        {
            this.die.Add(dice);
        }

        public int RollDie()
        {
            int totalResult = 0;
            foreach (Die die in die)
            {
                int result = die.Roll();
                totalResult += result;
            }

            return totalResult;
        }

        public string WriteDie()
        {
            string dieInCup = "";
            foreach (Die die in die)
            {
                dieInCup += die.ToString() + ", ";
            }
            return dieInCup;
        }

    }
}
