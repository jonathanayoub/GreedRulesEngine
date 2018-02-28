using GreedRulesEngine.Rules;
using NUnit.Framework;
using System.Collections.Generic;

namespace GreedRulesEngine.Tests.Rules
{
    [TestFixture]
    public class Given_a_roll_with_a_number_of_1s
    {
        private SingleOneRule _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SingleOneRule();
        }

        [Test]
        public void When_there_are_0_1s_then_the_score_is_0()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 2, 4, 5, 3, 5 });

            var score = _sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(0, score);
        }

        [Test]
        public void When_there_is_one_1_then_the_score_is_100()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 4, 5, 3, 5 });

            var score = _sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(100, score);
        }

        [Test]
        public void When_there_is_more_than_one_1_then_the_score_is_100()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1, 1, 3, 5 });

            var score = _sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(100, score);
        }
    }
}
