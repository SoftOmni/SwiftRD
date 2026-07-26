using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class UnownedSafeDeclarationModifier : SwiftCompositeNode, IUnownedSafeDeclarationModifier
{
    public Unowned Keyword { get; }

    public LeftParenthesis SafeStart { get; }

    public Safe SafeKeyword { get; }

    public RightParenthesis SafeEnd { get; }

    internal UnownedSafeDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Unowned keyword, LeftParenthesis safeStart, Safe safeKeyword, RightParenthesis safeEnd)
        : base(buffer, children)
    {
        Keyword = keyword;
        SafeStart = safeStart;
        SafeKeyword = safeKeyword;
        SafeEnd = safeEnd;
    }
}
