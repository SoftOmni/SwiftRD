using System;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AttachChild(int index, INode child)
    {
        throw new NotImplementedException();
    }

    public int AttachChild(int index, INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildLoose(int index, INode child)
    {
        throw new NotImplementedException();
    }

    public int AttachChildLoose(int index, INode child, Action<INode> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildConcrete(int index, Node child)
    {
        throw new NotImplementedException();
    }

    public int AttachChildConcrete(int index, Node child, Action<Node> actionOnAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildLoose<TNode>(int index, TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildLoose<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildConcrete<TNode>(int index, TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildConcrete<TNode>(int index, TNode child, Action<TNode> actionOnAddition)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}