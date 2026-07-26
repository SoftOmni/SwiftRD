namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalAnd;

public interface IOrCompilationCondition : IReadOnlyOrCompilationCondition, ICompilationCondition
{
    new ICompilationCondition LeftOperand { get; }

    void ChangeLeftOperand(ICompilationCondition compilationCondition);
    
    new ICompilationCondition RightOperand { get; }

    void ChangeRightOperand(ICompilationCondition compilationCondition);
}
