using GreedRulesEngine.Rules;
using System.Collections.Generic;

namespace GreedRulesEngine
{
    public static class Bootstrap
    {
        public static GreedGame BuildGame()
        {
            var diceRoll = new RandomDiceRoll(5);
            List<IScoreRule> rulesList = GetBasicRules();

            return new GreedGame(diceRoll, rulesList);
        }

        public static List<IScoreRule> GetBasicRules()
        {
            return new List<IScoreRule>
            {
                new SingleRule(DieFace.One),
                new SingleRule(DieFace.Five),
                new TripleRule(DieFace.One),
                new TripleRule(DieFace.Two),
                new TripleRule(DieFace.Three),
                new TripleRule(DieFace.Four),
                new TripleRule(DieFace.Five),
                new TripleRule(DieFace.Six)
            };
        }
    }
}
