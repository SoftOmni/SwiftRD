using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public interface IReadOnlyIfExpression : IReadOnlyConditionalExpression
{
    If If { get; }
    
    IReadOnlyConditionList ConditionList { get; }
    
    LeftCurlyBrace LeftCurlyBrace { get; }

    IReadOnlyList<IReadOnlyStatement> IfBlockStatements { get; }

    RightCurlyBrace RightCurlyBrace { get; }
    
    IReadOnlyList<IReadOnlyElseIfExpression> ElseIfExpressions { get; }

    IReadOnlyElseExpression ElseExpression { get; }
}
