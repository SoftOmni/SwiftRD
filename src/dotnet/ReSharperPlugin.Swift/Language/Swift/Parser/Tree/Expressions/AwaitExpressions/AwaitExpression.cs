using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

public class AwaitExpression : SwiftCompositeNode, IAwaitExpression
{
    public Await AwaitKeyword { get; }

    internal AwaitExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Await awaitKeyword)
        : base(buffer, children)
    {
        AwaitKeyword = awaitKeyword;
    }
}
