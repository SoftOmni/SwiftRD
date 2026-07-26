using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public interface IWhileStatement : IReadOnlyWhileStatement, ILoopStatement
{
    new IConditionList ConditionList { get; }

    void ChangeConditionList(IConditionList newConditionsList);
}
