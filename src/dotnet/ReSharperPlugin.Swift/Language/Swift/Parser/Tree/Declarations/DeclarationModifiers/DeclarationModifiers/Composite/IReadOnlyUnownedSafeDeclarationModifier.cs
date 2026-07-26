using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public interface IReadOnlyUnownedSafeDeclarationModifier :
    IReadOnlyUnownedDeclarationModifier
{
    LeftParenthesis SafeStart { get; }
    
    Safe SafeKeyword { get; }
    
    RightParenthesis SafeEnd { get; }
}
