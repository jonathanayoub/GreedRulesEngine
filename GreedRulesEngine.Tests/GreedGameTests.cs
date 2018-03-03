using GreedRulesEngine.Tests.Rules;
using NUnit.Framework;
using System.Collections.Generic;
using GreedRulesEngine.Core;

namespace GreedRulesEngine.Tests
{
    [TestFixture]
    public class Given_a_greed_game_with_a_random_dice_role_and_basic_rules
    {

        public GreedGame CreateGame(IDiceRoll stubRoll)
        {
            return new GreedGame(Bootstrap.GetRulesEngine(), stubRoll);
        }

        [Test]
        public void When_the_role_is_1_1_1_5_1_then_the_score_is_1150()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 1, 1, 5, 1 });
            var sut = CreateGame(stubRoll.Object);

            var score = sut.Play().Score;

            Assert.AreEqual(1150, score);
        }

        [Test]
        public void When_the_role_is_2_3_4_6_2_then_the_score_is_0()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 2, 3, 4, 6, 2 });
            var sut = CreateGame(stubRoll.Object);

            var score = sut.Play().Score;

            Assert.AreEqual(0, score);
        }

        [Test]
        public void When_the_role_is_3_4_5_3_3_then_the_score_is_350()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 3, 4, 5, 3, 3 });
            var sut = CreateGame(stubRoll.Object);

            var score = sut.Play().Score;

            Assert.AreEqual(350, score);
        }

        [Test]
        public void When_the_role_is_1_5_1_2_4_then_the_score_is_250()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 1, 5, 1, 2, 4 });
            var sut = CreateGame(stubRoll.Object);

            var score = sut.Play().Score;

            Assert.AreEqual(250, score);
        }

        [Test]
        public void When_the_role_is_5_5_5_5_5_then_the_score_is_600()
        {
            var stubRoll = FakeRollFactory.Create(new List<int> { 5, 5, 5, 5, 5 });
            var sut = CreateGame(stubRoll.Object);

            var score = sut.Play().Score;

            Assert.AreEqual(600, score);
        }
    }
}
