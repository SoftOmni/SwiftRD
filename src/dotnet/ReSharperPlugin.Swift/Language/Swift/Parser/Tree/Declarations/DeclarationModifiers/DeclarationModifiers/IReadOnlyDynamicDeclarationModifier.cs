namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IReadOnlyDynamicDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Dynamic Keyword { get; }
}
