using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;


namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int InsertChild(int index, INode child)
    {
        if (child is not Node node)
        {
            throw new NotSupportedException("You cannot insert a none flexible concrete node");
        }

        return InsertChild(index, node);
    }

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition)
    {
        if (child is not Node node)
        {
            throw new NotSupportedException("You cannot insert a none flexible concrete node");
        }

        return InsertChild(index, node);
    }

    public int InsertChild(int index, Node child) => InsertChildConcrete(index, child);

    public int InsertChild(int index, Node child, Action<Node> actionOnAddition) => InsertChildConcrete(index, child, actionOnAddition);

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
        if (child is not Node node)
        {
            throw new NotSupportedException("You cannot insert a none flexible concrete node");
        }
        
        CheckChildForAttachment(index, node);
        return AttachChildForcibly(index, node);
    }

    public int InsertChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        if (child is not Node node)
        {
            throw new NotSupportedException("You cannot insert a none flexible concrete node");
        }
        
        CheckChildForAttachment(index, node);
        int newParentTextIndex = AttachChildForcibly(index, node);
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