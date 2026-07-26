using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.InternalNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.Base;

public abstract class RegularExpressionNode<TSelf> :
    Node<IRegularExpressionNodeFamily<TSelf>, RegularExpressionNode<TSelf>, TSelf, RegularExpressionLeafNode<TSelf>>
    where TSelf : RegularExpressionInternalNode<TSelf>
{
    protected RegularExpressionNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected RegularExpressionNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }
}
