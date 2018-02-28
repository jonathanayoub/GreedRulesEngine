namespace GreedRulesEngine.Rules
{
    public class SingleFiveRule : IScoreRule
    {
        private const int SingleFiveScore = 50;

        public int CalculateScore(IDiceRoll roll)
        {
            var result = roll.Result;

            return result.Contains(5)
                ? SingleFiveScore
                : 0;
        }
    }
}
