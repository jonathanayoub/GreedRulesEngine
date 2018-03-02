using System.Linq;

namespace GreedRulesEngine.Rules
{
    public class SingleOneRule : IScoreRule
    {
        private const int SingleOneScore = 100;

        public int CalculateScore(IDiceRoll roll)
        {
            var result = roll.Result;

            var groupedRolls = result.GroupBy(r => r);
            var oneGroups = groupedRolls.SingleOrDefault(g => g.Key == 1);
            if (oneGroups == null)
                return 0;

            var numberOfOnes = oneGroups.Count();

            return numberOfOnes > 0
                ? SingleOneScore * GetNumberOfOnesToScore(numberOfOnes)
                : 0;
        }

        private int GetNumberOfOnesToScore(int numberOfOnes)
        {
            return numberOfOnes >= 3
                ? numberOfOnes - 3
                : numberOfOnes;
        }
    }
}
