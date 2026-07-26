namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyFinalDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Final Keyword { get; }
}
