using GreedRulesEngine.Core;

namespace GreedRulesEngine.Rules
{
    public interface IScoreRule
    {
        int CalculateScore(IDiceRoll roll);
    }
}
