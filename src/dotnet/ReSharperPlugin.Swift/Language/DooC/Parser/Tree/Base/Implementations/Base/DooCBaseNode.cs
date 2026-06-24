using DefaultNamespace;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Implementations.Base;

public abstract class DooCBaseNode<TSelf> : Node<IDooCNodeFamily<TSelf>, DooCBaseNode<TSelf>, TSelf, DooCLeafNode<TSelf>>
    where TSelf : DooCInternalNode<TSelf>
{
    protected DooCBaseNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected DooCBaseNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }
}