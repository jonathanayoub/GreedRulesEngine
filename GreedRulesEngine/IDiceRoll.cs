using System.Collections.Generic;

namespace GreedRulesEngine
{
    public interface IDiceRoll
    {
        IList<int> Result { get; }

        void Execute();
    }
}
