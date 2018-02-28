using System;
using System.Collections.Generic;

namespace GreedRulesEngine
{
    public class RandomDiceRoll : IDiceRoll
    {
        private readonly int _numberOfDice;

        public IList<int> Result { get; private set; }

        public RandomDiceRoll(int numberOfDice)
        {
            _numberOfDice = numberOfDice;
        }


        public void Execute()
        {
            var rolls = new List<int>();

            var random = new Random();
            for (int i = 1; i <= _numberOfDice; i++)
            {
                rolls.Add(random.Next(1, 7));
            }

            Result = rolls;
        }
    }
}
