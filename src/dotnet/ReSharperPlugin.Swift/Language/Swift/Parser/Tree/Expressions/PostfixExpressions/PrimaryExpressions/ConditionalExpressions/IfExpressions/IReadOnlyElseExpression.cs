using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public interface IReadOnlyElseExpression : IReadOnlyBaseExpression, IReadOnlyList<IReadOnlyStatement>
{
    Else Else { get; }
    
    LeftCurlyBrace LeftCurlyBrace { get; }
    
    IReadOnlyList<IReadOnlyStatement> Statements { get; }
    
    RightCurlyBrace RightCurlyBrace { get; }
}
