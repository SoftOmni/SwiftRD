using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers.Modifiers;

public interface IPrivateSetAccessLevelModifier :
    IReadOnlyPrivateSetAccessLevelModifier,
    ISetAccessLevelModifier
{
    new IPrivateAccessLevelModifier AccessLevelModifier { get; }
}
