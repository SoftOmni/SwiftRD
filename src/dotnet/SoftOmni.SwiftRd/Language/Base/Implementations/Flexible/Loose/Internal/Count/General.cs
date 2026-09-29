using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    /*public int Count(INode child, bool recursive)
    {
        int count = 0;

        if (recursive)
        {
            foreach (INode childNode in _children)
            {
                if (childNode == child)
                {
                    count++;
                }
            }
            
            return count;
        }
        
        foreach (INode childNode in _children)
        {
            if (childNode == child)
            {
                count++;
            }
            
            count += childNode.Count
        }
    }*/

    public int Count<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(INode child, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(TNode child, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(INode child, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(TNode child, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int CountInRange(INode child, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int CountInRange(Func<INode, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(Func<INode, bool> predicate, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, int, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate, int startIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int Count(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate, int startIndex, int count)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int CountInRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(Func<INode, int, bool> predicate, int startIndex, int endIndex)
        where TNode : INode
    {
        throw new NotImplementedException();
    }
}