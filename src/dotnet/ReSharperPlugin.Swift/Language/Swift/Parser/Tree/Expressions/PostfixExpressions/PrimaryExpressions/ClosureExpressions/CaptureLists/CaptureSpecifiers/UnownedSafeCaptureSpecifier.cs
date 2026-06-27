using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureSpecifiers;

public class UnownedSafeCaptureSpecifier : SwiftCompositeNode, IUnownedSafeCaptureSpecifier
{
    public Unowned Unowned { get; }

    public LeftParenthesis SafeModifierStart { get; }

    public Safe SafeModifier { get; }

    public RightParenthesis SafeModifierEnd { get; }

    internal UnownedSafeCaptureSpecifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Unowned unowned, LeftParenthesis safeModifierStart, Safe safeModifier, RightParenthesis safeModifierEnd)
        : base(buffer, children)
    {
        Unowned = unowned;
        SafeModifierStart = safeModifierStart;
        SafeModifier = safeModifier;
        SafeModifierEnd = safeModifierEnd;
    }    
}
