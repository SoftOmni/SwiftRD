using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Modifiers;

public interface IReadOnlyFilePrivateAccessLevelModifier
    : IReadOnlyAccessLevelModifier
{
    FilePrivate FilePrivate { get; }
}
