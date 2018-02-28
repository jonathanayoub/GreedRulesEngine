namespace GreedRulesEngine.Rules
{
    public class SingleOneRule : IScoreRule
    {
        private const int SingleOneScore = 100;

        public int CalculateScore(IDiceRoll roll)
        {
            var result = roll.Result;

            return result.Contains(1)
                ? SingleOneScore
                : 0;
        }
    }
}
