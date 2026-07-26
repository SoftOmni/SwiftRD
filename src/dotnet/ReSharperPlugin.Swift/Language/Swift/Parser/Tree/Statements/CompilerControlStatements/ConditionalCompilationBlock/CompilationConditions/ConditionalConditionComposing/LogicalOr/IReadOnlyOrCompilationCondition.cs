using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalAnd;

public interface IReadOnlyOrCompilationCondition : IReadOnlyCompilationCondition
{
    IReadOnlyOperator Operator { get; }
    
    IReadOnlyCompilationCondition LeftOperand { get; }
    
    IReadOnlyCompilationCondition RightOperand { get; }
}
