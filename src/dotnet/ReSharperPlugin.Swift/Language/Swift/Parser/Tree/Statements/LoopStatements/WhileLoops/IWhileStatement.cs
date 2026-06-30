using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public interface IWhileStatement : ILoopStatement, IList<ICondition>
{
    new IConditionList ConditionList { get; }
}
