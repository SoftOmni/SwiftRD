using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class StaticDeclarationModifier : SwiftCompositeNode, IStaticDeclarationModifier
{
    public Static Keyword { get; }

    internal StaticDeclarationModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Static keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}