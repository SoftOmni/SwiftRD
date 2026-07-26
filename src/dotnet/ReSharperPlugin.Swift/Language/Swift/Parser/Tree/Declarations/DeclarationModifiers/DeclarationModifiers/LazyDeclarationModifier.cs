using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class LazyDeclarationModifier : SwiftCompositeNode, ILazyDeclarationModifier
{
    public Lazy Keyword { get; }

    internal LazyDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Lazy keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}
