using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public interface IRepeatWhileStatement : IReadOnlyRepeatWhileStatement, ILoopStatement
{
    new IExpression ConditionExpression { get; }
}
