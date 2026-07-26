using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public interface IReadOnlyRepeatWhileStatement : IReadOnlyLoopStatement
{
    Repeat Repeat { get; }
    
    While While { get; }
    
    IReadOnlyExpression ConditionExpression { get; }
}
