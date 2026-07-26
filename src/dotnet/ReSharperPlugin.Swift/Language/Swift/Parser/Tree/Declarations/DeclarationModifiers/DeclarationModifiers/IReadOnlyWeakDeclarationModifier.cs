namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyWeakDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Weak Keyword { get; }
}
