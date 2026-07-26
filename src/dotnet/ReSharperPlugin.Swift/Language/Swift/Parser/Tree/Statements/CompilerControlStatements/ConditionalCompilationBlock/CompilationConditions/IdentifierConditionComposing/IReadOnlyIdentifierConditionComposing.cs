using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.IdentifierConditionComposing;

public interface IReadOnlyIdentifierConditionComposing : IReadOnlyCompilationCondition
{
    IReadOnlyIdentifier Identifier { get; }
}
