namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public interface IRedOnlyRequiredDeclarationModifier :
    IReadOnlyDeclarationModifier
{
    Required Keyword { get; }
}