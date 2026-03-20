using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public bool Contains(INode child)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(INode child, int startIndex)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(TNode child, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(INode child, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(TNode child, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange(INode child, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, bool> predicate)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, bool> predicate, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, bool> predicate, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange(Func<INode, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange<TNode>(Func<INode, bool> predicate, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, int, bool> predicate)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, int, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, int, bool> predicate, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool Contains(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public bool Contains<TNode>(Func<TNode, int, bool> predicate, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public bool ContainsInRange<TNode>(Func<INode, int, bool> predicate, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }
}