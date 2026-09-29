using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public int InsertChild(int index, INode child);

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition);

    public int InsertChild<TNode>(int index, TNode child) where TNode : INode;

    public int InsertChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition) where TNode : INode;
}