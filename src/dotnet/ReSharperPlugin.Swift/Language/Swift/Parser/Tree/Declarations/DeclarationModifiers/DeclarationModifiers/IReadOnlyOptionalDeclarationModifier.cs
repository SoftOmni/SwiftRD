namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyOptionalDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Optional Keyword { get; }
}
