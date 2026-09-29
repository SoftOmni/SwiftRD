using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Base;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public void PrependChild(INode child) => PrependChildLoose(child);

    public void PrependChild(INode child, Action<INode> actionOnAddition) => PrependChildLoose(child, actionOnAddition);
    
    public void PrependChildLoose(INode child)
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChildLoose(INode child, Action<INode> actionOnAddition)
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
        actionOnAddition(child);
    }

    public void PrependChildConcrete(Node child)
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChildConcrete(Node child, Action<Node> actionOnAddition)
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
        actionOnAddition(child);
    }

    public void PrependChild<TNode>(TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChild<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
        actionOnAddition(child);
    }

    public void PrependChildLoose<TNode>(TNode child)
        where TNode : INode
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChildLoose<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
        actionOnAddition(child);
    }

    public void PrependChildConcrete<TNode>(TNode child)
        where TNode : Node
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChildConcrete<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
        actionOnAddition(child);
    }
}