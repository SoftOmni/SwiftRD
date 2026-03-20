using System;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int AppendChild(INode child)
    {
        int currentLength = GetTextLength();
        throw new NotImplementedException();
        
        
        return currentLength;
    }

    public int AppendChild(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose(INode child)
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete(Node child)
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete(Node child, Action<Node> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChild<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChild<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}