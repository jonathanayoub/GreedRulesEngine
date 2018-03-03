using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreedRulesEngine.Rules;

namespace GreedRulesEngine.Core
{
    public class GreedRulesEngine
    {
        private readonly IList<IScoreRule> _scoreRules;

        public GreedRulesEngine(IList<IScoreRule> scoreRules)
        {
            _scoreRules = scoreRules ?? throw new ArgumentNullException(nameof(scoreRules));
        }

        public int ScoreGame(IDiceRoll diceRoll)
        {
            var score = 0;
            foreach (var scoreRule in _scoreRules)
            {
                score += scoreRule.CalculateScore(diceRoll);
            }
            return score;
        }
    }
}
