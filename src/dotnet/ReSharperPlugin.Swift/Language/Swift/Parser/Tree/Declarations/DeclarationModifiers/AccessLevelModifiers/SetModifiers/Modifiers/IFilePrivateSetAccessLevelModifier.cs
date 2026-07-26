using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers.Modifiers;

public interface IFilePrivateSetAccessLevelModifier :
    IReadOnlyFilePrivateSetAccessLevelModifier,
    ISetAccessLevelModifier
{
    new IFilePrivateAccessLevelModifier AccessLevelModifier { get; }
}
