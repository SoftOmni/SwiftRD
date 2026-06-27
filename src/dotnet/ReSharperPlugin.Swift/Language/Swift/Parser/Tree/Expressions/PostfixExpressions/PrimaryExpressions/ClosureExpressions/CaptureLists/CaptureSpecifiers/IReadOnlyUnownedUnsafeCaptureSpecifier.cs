using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

public interface IReadOnlyUnownedUnsafeCaptureSpecifier : IReadOnlyCaptureSpecifier
{
    Unowned Unowned { get; }
    
    LeftParenthesis UnsafeModifierStart { get; }
    
    Unsafe UnsafeModifier { get; }
    
    RightParenthesis UnsafeModifierEnd { get; }
}
