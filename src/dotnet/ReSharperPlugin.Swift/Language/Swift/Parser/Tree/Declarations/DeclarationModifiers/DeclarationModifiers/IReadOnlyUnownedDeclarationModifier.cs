namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyUnownedDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Unowned Keyword { get; }
}
