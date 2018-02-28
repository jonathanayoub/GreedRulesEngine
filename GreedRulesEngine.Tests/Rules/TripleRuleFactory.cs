using GreedRulesEngine.Rules;

namespace GreedRulesEngine.Tests.Rules
{
    public static class TripleRuleFactory
    {
        public static TripleRule Create(DieFace dieFace)
        {
            return new TripleRule(dieFace);
        }
    }
}
