using NUnit.Framework;
using System.Collections.Generic;

namespace GreedRulesEngine.Tests.Rules
{
    [TestFixture]
    public class Given_a_roll_with_no_triples
    {
        [Test]
        public void When_there_are_no_triple_1s_then_the_score_is_0()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1, 2, 3, 4 });
            var sut = TripleRuleFactory.Create(DieFace.One);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(0, score);
        }

        [Test]
        public void When_there_are_no_triple_6s_then_the_score_is_0()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1 });
            var sut = TripleRuleFactory.Create(DieFace.Six);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(0, score);
        }
    }

    [TestFixture]
    public class Given_a_roll_with_triples
    {
        [Test]
        public void When_there_are_triple_1s_then_the_score_is_1000()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1, 1, 2, 3 });
            var sut = TripleRuleFactory.Create(DieFace.One);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(1000, score);
        }

        [Test]
        public void When_there_are_triple_2s_then_the_score_is_200()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 2, 2, 2, 2, 3 });
            var sut = TripleRuleFactory.Create(DieFace.Two);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(200, score);
        }

        [Test]
        public void When_there_are_triple_3s_then_the_score_is_300()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1, 3, 3, 3 });
            var sut = TripleRuleFactory.Create(DieFace.Three);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(300, score);
        }

        [Test]
        public void When_there_are_triple_4s_then_the_score_is_400()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 4, 4, 4, 3 });
            var sut = TripleRuleFactory.Create(DieFace.Four);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(400, score);
        }

        [Test]
        public void When_there_are_triple_5s_then_the_score_is_500()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 4, 5, 4, 5, 5 });
            var sut = TripleRuleFactory.Create(DieFace.Five);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(500, score);
        }

        [Test]
        public void When_there_are_triple_6s_then_the_score_is_600()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 6, 1, 6, 6, 1 });
            var sut = TripleRuleFactory.Create(DieFace.Six);

            var score = sut.CalculateScore(stubRoll.Object);

            Assert.AreEqual(600, score);
        }
    }
}
