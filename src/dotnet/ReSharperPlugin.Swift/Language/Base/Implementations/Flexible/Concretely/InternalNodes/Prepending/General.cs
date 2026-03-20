using System;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public void PrependChild(INode child)
    {
        throw new NotImplementedException();
    }

    public void PrependChild(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildLoose(INode child)
    {
        throw new NotImplementedException();
    }

    public void PrependChildLoose(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildConcrete(Node child)
    {
        throw new NotImplementedException();
    }

    public void PrependChildConcrete(Node child, Action<Node> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChild<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChild<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildLoose<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildLoose<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildConcrete<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildConcrete<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}