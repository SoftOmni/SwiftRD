namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.ConditionalConditionComposing.ParenthesizedCondition;

public interface IParenthesizedCompilationCondition :
    IReadOnlyParenthesizedCompilationCondition,
    ICompilationCondition
{
    new ICompilationCondition CompilationCondition { get; }

    void ChangeCompilationCondition(ICompilationCondition newCompilationCondition);
}
