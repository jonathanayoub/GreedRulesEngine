using Moq;
using System.Collections.Generic;

namespace GreedRulesEngine.Tests.Rules
{
    public static class FakeRollFactory
    {
        public static Mock<IDiceRoll> Create(IList<int> rolls)
        {
            var stubRoll = new Mock<IDiceRoll>();
            stubRoll
                .Setup(r => r.Result)
                .Returns(rolls);
            return stubRoll;
        }
    }
}
