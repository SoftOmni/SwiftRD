namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyLazyDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Lazy Keyword { get; }
}
