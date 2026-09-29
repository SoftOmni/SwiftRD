using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public void PrependChild(Node child) => PrependChildConcrete(child);

    public void PrependChild(Node child, Action<Node> actionOnAddition) => PrependChildConcrete(child, actionOnAddition);

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
        where TNode : Node
    {
        CheckChildForAttachment(0, child);
        AttachChildForcibly(0, child);
    }

    public void PrependChild<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
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