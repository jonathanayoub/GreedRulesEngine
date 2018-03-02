using System;
using System.Linq;

namespace GreedRulesEngine.Rules
{
    public class SingleRule : IScoreRule
    {
        private readonly DieFace _faceToScore;
        private const int SingleOneScore = 100;
        private const int SingleFiveScore = 50;

        public SingleRule(DieFace faceToScore)
        {
            if (faceToScore != DieFace.One && faceToScore != DieFace.Five)
                throw new ArgumentException("Single dice score only valid for one and five");
            _faceToScore = faceToScore;
        }

        public int CalculateScore(IDiceRoll roll)
        {
            var result = roll.Result;

            var groupedRolls = result.GroupBy(r => r);
            var faceroups = groupedRolls.SingleOrDefault(g => g.Key == (int)_faceToScore);
            if (faceroups == null)
                return 0;

            var numberOfSingles = faceroups.Count();

            if (numberOfSingles > 0)
            {
                return GetScore(numberOfSingles);
            }

            return 0;
        }

        private int GetScore(int numberOfSingles)
        {
            switch (_faceToScore)
            {
                case DieFace.One:
                    return SingleOneScore * GetNumberOfSinglesToScore(numberOfSingles);
                case DieFace.Five:
                    return SingleFiveScore * GetNumberOfSinglesToScore(numberOfSingles);
                default:
                    throw new InvalidOperationException("I don't know how you broke me, but something's very, very wrong.");
            }
        }

        private int GetNumberOfSinglesToScore(int numberOfSingles)
        {
            return numberOfSingles >= 3
                ? numberOfSingles - 3
                : numberOfSingles;
        }
    }
}
