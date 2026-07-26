namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyOverrideDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Override Keyword { get; }
}
