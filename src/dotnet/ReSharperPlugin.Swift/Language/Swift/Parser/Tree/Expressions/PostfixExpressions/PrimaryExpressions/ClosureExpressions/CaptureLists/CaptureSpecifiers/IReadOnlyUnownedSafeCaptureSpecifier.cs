using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

public interface IReadOnlyUnownedSafeCaptureSpecifier : IReadOnlyCaptureSpecifier
{
    Unowned Unowned { get; }
    
    LeftParenthesis SafeModifierStart { get; }
    
    Safe SafeModifier { get; }
    
    RightParenthesis SafeModifierEnd { get; }
}
