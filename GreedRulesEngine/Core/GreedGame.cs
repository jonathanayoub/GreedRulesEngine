using System;
using System.Collections.Generic;
using GreedRulesEngine.Rules;

namespace GreedRulesEngine.Core
{
    public class GreedGame
    {
        private readonly GreedRulesEngine _rulesEngine;
        private readonly IDiceRoll _diceRoll;

        public GreedGame(GreedRulesEngine rulesEngine, IDiceRoll diceRoll)
        {
            _diceRoll = diceRoll ?? throw new ArgumentNullException(nameof(diceRoll));
            _rulesEngine = rulesEngine ?? throw new ArgumentNullException(nameof(rulesEngine));
        }

        public GreedGameResult Play()
        {
            _diceRoll.Execute();

            var score = _rulesEngine.ScoreGame(_diceRoll);

            return new GreedGameResult
            {
                Roll = _diceRoll,
                Score = score
            };
        }        
    }
}
