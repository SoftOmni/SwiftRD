using JetBrains.Text;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;

public abstract class RegularExpressionLeafNode<TSelf> :
    LeafNode<IRegularExpressionNodeFamily<TSelf>, RegularExpressionLeafNode<TSelf>, TSelf>,
    IRegularExpressionLeafNode<TSelf>
    where TSelf : class, IRegularExpressionInternalNode<TSelf>
{
    protected RegularExpressionLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected RegularExpressionLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    TSelf INode<IRegularExpressionNodeFamily<TSelf>, TSelf, TSelf, RegularExpressionLeafNode<TSelf>>.CloneAsDetached()
    {
        throw new System.NotImplementedException();
    }

    TSelf INode<IRegularExpressionNodeFamily<TSelf>, TSelf, TSelf, RegularExpressionLeafNode<TSelf>>.CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new System.NotImplementedException();
    }

    IRegularExpressionNode<TSelf> IRegularExpressionLeafNode<TSelf>.CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new System.NotImplementedException();
    }

    IRegularExpressionNode<TSelf> IRegularExpressionLeafNode<TSelf>.CloneAsDetached()
    {
        throw new System.NotImplementedException();
    }
}
