namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyPrefixDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Prefix Keyword { get; }
}
