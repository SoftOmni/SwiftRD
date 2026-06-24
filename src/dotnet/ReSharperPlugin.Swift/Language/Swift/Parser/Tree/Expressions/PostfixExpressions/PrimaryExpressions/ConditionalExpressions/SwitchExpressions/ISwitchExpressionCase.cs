using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

public interface ISwitchExpressionCase : IReadOnlySwitchExpressionCase
{
    new IStatement Statement { get; }

    void ChangeStatement(IStatement newStatement);
}
