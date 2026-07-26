using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers.Modifiers;

public interface IReadOnlyInternalSetAccessLevelModifier :
    IReadOnlySetAccessLevelModifier
{
    new IReadOnlyInternalAccessLevelModifier AccessLevelModifier { get; }
}
