using System.Linq;

namespace GreedRulesEngine.Rules
{
    public class SingleFiveRule : IScoreRule
    {
        private const int SingleFiveScore = 50;

        public int CalculateScore(IDiceRoll roll)
        {
            var result = roll.Result;

            var groupedRolls = result.GroupBy(r => r);
            var fiveGroups = groupedRolls.SingleOrDefault(g => g.Key == 5);
            if (fiveGroups == null)
                return 0;

            var numberOfFives = fiveGroups.Count();

            return numberOfFives > 0
                ? SingleFiveScore * GetNumberOfFivesToScore(numberOfFives)
                : 0;
        }

        private int GetNumberOfFivesToScore(int numberOfFives)
        {
            return numberOfFives >= 3
                ? numberOfFives - 3
                : numberOfFives;
        }
    }
}
