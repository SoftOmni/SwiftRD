using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class OverrideDeclarationModifier : SwiftCompositeNode,
    IOverrideDeclarationModifier
{
    public Override Keyword { get; }

    internal OverrideDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Override keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}