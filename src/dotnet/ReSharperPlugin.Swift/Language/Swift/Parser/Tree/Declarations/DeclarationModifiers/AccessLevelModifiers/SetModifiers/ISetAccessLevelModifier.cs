namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers;

public interface ISetAccessLevelModifier :
    IReadOnlySetAccessLevelModifier, IAccessLevelModifier
{
    new IAccessLevelModifier AccessLevelModifier { get; }
}
    