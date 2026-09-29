using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public int AttachChild(int index, INode child);

    public int AttachChild(int index, INode child, Action<INode> actionOnAttachment);

    public int AttachChild<TNode>(int index, TNode child)
        where TNode : INode;

    public int AttachChild<TNode>(int index, TNode child, Action<TNode> actionOnAttachment)
        where TNode : INode;
}