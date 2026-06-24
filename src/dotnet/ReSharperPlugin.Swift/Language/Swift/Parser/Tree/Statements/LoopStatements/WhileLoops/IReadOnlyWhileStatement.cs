namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.WhileLoops;

public interface IReadOnlyWhileStatement : IReadOnlyLoop
{
    While While { get; }
    
    IReadOnlyConditionList ConditionList { get; }
}
