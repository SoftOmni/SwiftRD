using System;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal int AppendChildForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildForcibly(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildLooseForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildLooseForcibly(INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildConcreteForcibly(Node child)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildConcreteForcibly(Node child, Action<Node> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildForcibly<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildLooseForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildLooseForcibly<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildConcreteForcibly<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildConcreteForcibly<TNode>(TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}