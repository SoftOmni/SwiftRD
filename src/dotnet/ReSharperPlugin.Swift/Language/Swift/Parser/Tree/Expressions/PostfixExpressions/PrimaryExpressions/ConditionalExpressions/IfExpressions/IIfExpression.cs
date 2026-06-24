using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public interface IIfExpression : IReadOnlyIfExpression, IConditionalExpression
{
    new IConditionList ConditionList { get; }
    
    new IReadOnlyList<IStatement> IfBlockStatements { get; }
    
    new IReadOnlyList<IElseIfExpression> ElseIfExpressions { get; }
    
    new IElseExpression ElseExpression { get; }

    void ChangeConditionList(IConditionList newConditionList);

    void ChangeElseExpression(IElseExpression newElseExpression);
}
