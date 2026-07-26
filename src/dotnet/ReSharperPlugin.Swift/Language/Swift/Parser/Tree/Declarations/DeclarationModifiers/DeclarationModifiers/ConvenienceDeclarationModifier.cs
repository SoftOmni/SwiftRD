using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

public class ConvenienceDeclarationModifier : SwiftCompositeNode, IConvenienceDeclarationModifier
{
    public Convenience Keyword { get; }

    internal ConvenienceDeclarationModifier(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Convenience keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}