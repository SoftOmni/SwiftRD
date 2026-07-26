using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.IdentifierConditionComposing;

public interface IIdentifierConditionComposing : 
    IReadOnlyIdentifierConditionComposing, 
    ICompilationCondition
{
    new IIdentifier Identifier { get; }

    void ChangeIdentifier(IIdentifier newIdentifier);
}
