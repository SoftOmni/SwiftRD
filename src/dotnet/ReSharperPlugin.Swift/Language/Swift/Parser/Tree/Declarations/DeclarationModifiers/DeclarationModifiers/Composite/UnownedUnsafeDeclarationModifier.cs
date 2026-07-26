using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class UnownedUnsafeDeclarationModifier : SwiftCompositeNode, IUnownedUnsafeDeclarationModifier
{
    public Unowned Keyword { get; }

    public LeftParenthesis SafeStart { get; }

    public Unsafe UnsafeKeyword { get; }

    public RightParenthesis SafeEnd { get; }

    internal UnownedUnsafeDeclarationModifier(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Unowned keyword, LeftParenthesis safeStart,
        Unsafe unsafeKeyword, RightParenthesis safeEnd)
        : base(buffer, children)
    {
        Keyword = keyword;
        SafeStart = safeStart;
        UnsafeKeyword = unsafeKeyword;
        SafeEnd = safeEnd;
    }
}