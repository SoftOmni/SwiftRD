using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class DynamicDeclarationModifier : SwiftCompositeNode, IDynamicDeclarationModifier
{
    public Dynamic Keyword { get; }

    internal DynamicDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Dynamic keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}
