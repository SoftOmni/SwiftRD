using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

public interface IConditionList : IReadOnlyConditionList, IList<ICondition>
{
    new IReadOnlyList<ICondition> Conditions { get; }
    
    new int Count { get; }

    new IEnumerator<ICondition> GetEnumerator();
    
    new ICondition this[int index] { get; }
}
