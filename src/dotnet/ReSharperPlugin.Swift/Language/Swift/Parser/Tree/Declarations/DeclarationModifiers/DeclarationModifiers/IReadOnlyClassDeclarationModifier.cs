namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyClassDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Class Keyword { get; }
}
