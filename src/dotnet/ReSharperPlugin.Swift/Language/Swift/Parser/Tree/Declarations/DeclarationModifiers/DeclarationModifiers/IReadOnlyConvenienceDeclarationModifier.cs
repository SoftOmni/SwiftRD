namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyConvenienceDeclarationModifier
    : IReadOnlyDeclarationModifier
{
    Convenience Keyword { get; }
}
