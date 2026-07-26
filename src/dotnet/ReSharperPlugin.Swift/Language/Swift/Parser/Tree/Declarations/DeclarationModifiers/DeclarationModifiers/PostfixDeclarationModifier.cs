using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class PostfixDeclarationModifier : SwiftCompositeNode, IPostfixDeclarationModifier
{
    public Postfix Keyword { get; }

    internal PostfixDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Postfix keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}