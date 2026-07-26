using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.SetModifiers.Modifiers;

public interface IInternalSetAccessLevelModifier :
    IReadOnlyInternalSetAccessLevelModifier,
    ISetAccessLevelModifier
{
    new IInternalAccessLevelModifier AccessLevelModifier { get; }
}
