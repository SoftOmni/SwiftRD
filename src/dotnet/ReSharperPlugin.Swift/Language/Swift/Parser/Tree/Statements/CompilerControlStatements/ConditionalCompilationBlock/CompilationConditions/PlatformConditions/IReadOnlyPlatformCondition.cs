using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

public interface IReadOnlyPlatformCondition : IReadOnlyCompilationCondition
{
    IReadOnlyIdentifier PlatformConditionFunction { get; }
    
    LeftParenthesis PlatformConditionFunctionArgumentsStart { get; }
    
    RightParenthesis PlatformConditionFunctionArgumentsEnd { get; }
}
