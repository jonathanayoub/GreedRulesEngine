using GreedRulesEngine.Rules;
using System.Collections.Generic;
using GreedRulesEngine.Core;

namespace GreedRulesEngine
{
    public static class Bootstrap
    {
        public static GreedGame BuildGame()
        {
            var diceRoll = new RandomDiceRoll(5);
            return new GreedGame(GetRulesEngine(), diceRoll);
        }

        public static Core.GreedRulesEngine GetRulesEngine()
        {
            return new Core.GreedRulesEngine(
                new List<IScoreRule>
                {
                    new SingleRule(DieFace.One),
                    new SingleRule(DieFace.Five),
                    new TripleRule(DieFace.One),
                    new TripleRule(DieFace.Two),
                    new TripleRule(DieFace.Three),
                    new TripleRule(DieFace.Four),
                    new TripleRule(DieFace.Five),
                    new TripleRule(DieFace.Six)
                });
        }
    }
}
