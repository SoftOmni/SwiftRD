using DefaultNamespace;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Implementations.Base;

public abstract class DocCBaseNode<TSelf> : Node<IDocCNodeFamily<TSelf>, DocCBaseNode<TSelf>, TSelf, DocCLeafNode<TSelf>>
    where TSelf : DocCInternalNode<TSelf>
{
    protected DocCBaseNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected DocCBaseNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }
}