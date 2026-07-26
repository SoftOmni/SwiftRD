using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.BooleanCondition;

public interface IReadOnlyBooleanCondition : IReadOnlyCompilationCondition
{
    IReadOnlyBooleanLiteral BooleanLiteral { get; }
}
