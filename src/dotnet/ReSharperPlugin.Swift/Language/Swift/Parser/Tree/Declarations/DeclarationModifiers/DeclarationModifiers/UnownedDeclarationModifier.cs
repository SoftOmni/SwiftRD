using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class UnownedDeclarationModifier : SwiftCompositeNode, IUnownedDeclarationModifier
{
    public Unowned Keyword { get; }

    internal UnownedDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Unowned keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}
