using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalAnd;

public interface IReadOnlyOrCompilationCondition : IReadOnlyCompilationCondition
{
    IReadOnlyOperator Operator { get; }
    
    IReadOnlyCompilationCondition LeftOperand { get; }
    
    IReadOnlyCompilationCondition RightOperand { get; }
}
