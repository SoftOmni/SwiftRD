namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalAnd;

public interface IAndCompilationCondition : IReadOnlyAndCompilationCondition, ICompilationCondition
{
    new ICompilationCondition LeftOperand { get; }

    void ChangeLeftOperand(ICompilationCondition newLeftOperand);
    
    new ICompilationCondition RightOperand { get; }

    void ChangeRightOperand(ICompilationCondition newRightOperand);
}
