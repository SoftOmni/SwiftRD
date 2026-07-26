namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalNot;

public interface INotCompilationCondition : IReadOnlyNotCompilationCondition, ICompilationCondition
{
    new ICompilationCondition Operand { get; }

    void ChangeOperand(ICompilationCondition newOperand);
}
