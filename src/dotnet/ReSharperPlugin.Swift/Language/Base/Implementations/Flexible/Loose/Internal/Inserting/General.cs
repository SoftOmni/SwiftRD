using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Base;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int InsertChild(int index, INode child) => InsertChildLoose(index, child);

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition) => InsertChildLoose(index, child, actionOnAddition);

    public int InsertChildLoose(int index, INode child)
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int InsertChildLoose(int index, INode child, Action<INode> actionOnAddition)
    {
        CheckChildForAttachment(index, child);
        int newParentTextIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return newParentTextIndex;
    }

    public int InsertChildConcrete(int index, Node child)
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int InsertChildConcrete(int index, Node child, Action<Node> actionOnAddition)
    {
        CheckChildForAttachment(index, child);
        int newParentTextIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return newParentTextIndex;
    }

    public int InsertChild<TNode>(int index, TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int InsertChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        int newParentTextIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return newParentTextIndex;
    }

    public int InsertChildLoose<TNode>(int index, TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int InsertChildLoose<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(index, child);
        int newParentTextIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return newParentTextIndex;
    }

    public int InsertChildConcrete<TNode>(int index, TNode child)
        where TNode : Node
    {
        CheckChildForAttachment(index, child);
        return AttachChildForcibly(index, child);
    }

    public int InsertChildConcrete<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        CheckChildForAttachment(index, child);
        int newParentTextIndex = AttachChildForcibly(index, child);
        actionOnAddition(child);
        return newParentTextIndex;
    }
}