using GreedRulesEngine.Rules;
using System;
using System.Collections.Generic;

namespace GreedRulesEngine
{
    public class GreedGame
    {
        private readonly IList<IScoreRule> _scoreRules;
        private readonly IDiceRoll _diceRoll;

        public GreedGame(IDiceRoll diceRoll, IList<IScoreRule> scoreRules)
        {
            _diceRoll = diceRoll ?? throw new ArgumentNullException(nameof(diceRoll));
            _scoreRules = scoreRules ?? throw new ArgumentNullException(nameof(scoreRules));
        }

        public GreedGameResult Play()
        {
            _diceRoll.Execute();

            var score = ScoreGame();

            return new GreedGameResult
            {
                Roll = _diceRoll,
                Score = score
            };
        }

        private int ScoreGame()
        {
            var score = 0;
            foreach (var scoreRule in _scoreRules)
            {
                score += scoreRule.CalculateScore(_diceRoll);
            }
            return score;
        }
    }
}
