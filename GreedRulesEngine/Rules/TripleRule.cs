using System;
using System.Linq;

namespace GreedRulesEngine.Rules
{
    public class TripleRule : IScoreRule
    {
        private readonly DieFace _dieFace;
        private const int TripleOneScore = 1000;
        private const int TripleTwoScore = 200;
        private const int TripleThreeScore = 300;
        private const int TripleFourScore = 400;
        private const int TripleFiveScore = 500;
        private const int TripleSixScore = 600;

        public TripleRule(DieFace dieFace)
        {
            if (dieFace == DieFace.None)
                throw new ArgumentException("Must specify desired die face");
            _dieFace = dieFace;
        }

        public int CalculateScore(IDiceRoll roll)
        {
            var rollGroups = roll.Result.GroupBy(i => i);
            var faceGroup = rollGroups
                .FirstOrDefault(g => g.Key == (int)_dieFace);
            if (faceGroup == null)
                return 0;

            var faceGroupCount = faceGroup.Count();

            if (faceGroupCount < 3)
                return 0;

            switch (_dieFace)
            {
                case DieFace.One:
                    return TripleOneScore;
                case DieFace.Two:
                    return TripleTwoScore;
                case DieFace.Three:
                    return TripleThreeScore;
                case DieFace.Four:
                    return TripleFourScore;
                case DieFace.Five:
                    return TripleFiveScore;
                case DieFace.Six:
                    return TripleSixScore;
                default:
                    return 0;
            }
        }
    }
}
