using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class OptionalDeclarationModifier : SwiftCompositeNode,
    IOptionalDeclarationModifier
{
    public Optional Keyword { get; }

    internal OptionalDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Optional keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}