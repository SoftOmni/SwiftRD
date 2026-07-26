using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.BooleanCondition;

public interface IBooleanCondition : IReadOnlyBooleanCondition, ICompilationCondition
{
    new IBooleanLiteral BooleanLiteral { get; }

    void Invert();

    void MakeTrue();

    void MakeFalse();

    void ChangeBooleanLiteral(IBooleanLiteral newBooleanLiteral);
}
