using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions.ConditionalConditionComposing.ParenthesizedCondition;

public interface IReadOnlyParenthesizedCompilationCondition
    : IReadOnlyCompilationCondition
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyCompilationCondition CompilationCondition { get; }
    
    RightParenthesis RightParenthesis { get; }
}
