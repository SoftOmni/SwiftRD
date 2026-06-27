using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.CaptureLists.CaptureSpecifiers;

public class UnownedUnsafeCaptureSpecifier : SwiftCompositeNode, IUnownedUnsafeCaptureSpecifier
{
    public Unowned Unowned { get; }

    public LeftParenthesis UnsafeModifierStart { get; }

    public Unsafe UnsafeModifier { get; }

    public RightParenthesis UnsafeModifierEnd { get; }

    internal UnownedUnsafeCaptureSpecifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Unowned unowned, LeftParenthesis unsafeModifierStart, Unsafe unsafeModifier, RightParenthesis unsafeModifierEnd)
        : base(buffer, children)
    {
        Unowned = unowned;
        UnsafeModifierStart = unsafeModifierStart;
        UnsafeModifier = unsafeModifier;
        UnsafeModifierEnd = unsafeModifierEnd;
    }
}