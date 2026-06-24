using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

public interface IReadOnlySwitchExpression : IReadOnlyConditionalExpression, IReadOnlyList<IReadOnlySwitchExpressionCase>
{
    Switch Switch { get; }
    
    IReadOnlyExpression Expression { get; }
    
    LeftCurlyBrace LeftCurlyBrace { get; }

    IReadOnlyList<IReadOnlySwitchExpressionCase> Cases { get; }
    
    RightCurlyBrace RightCurlyBrace { get; }
}
