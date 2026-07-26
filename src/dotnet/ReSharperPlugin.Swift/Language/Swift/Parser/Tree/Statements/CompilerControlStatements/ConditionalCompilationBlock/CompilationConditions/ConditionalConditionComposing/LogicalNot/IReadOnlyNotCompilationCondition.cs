using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalNot;

public interface IReadOnlyNotCompilationCondition : IReadOnlyCompilationCondition
{
    IReadOnlyOperator Operator { get; }
    
    IReadOnlyCompilationCondition Operand { get; }
}
