using System.Collections.Generic;

namespace GreedRulesEngine.Core
{
    public interface IDiceRoll
    {
        IList<int> Result { get; }

        void Execute();
    }
}
