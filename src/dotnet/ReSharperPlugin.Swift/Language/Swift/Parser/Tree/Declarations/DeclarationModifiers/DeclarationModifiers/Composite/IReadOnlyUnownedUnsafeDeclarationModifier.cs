using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public interface IReadOnlyUnownedUnsafeDeclarationModifier :
    IReadOnlyUnownedDeclarationModifier
{
    LeftParenthesis SafeStart { get; }
    
    Unsafe UnsafeKeyword { get; }
    
    RightParenthesis SafeEnd { get; }
}