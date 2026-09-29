using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    /*public int Count(Node child, bool recursive)
    {
        int count = 0;

        if (recursive)
        {
            foreach (Node childNode in _children)
            {
                if (childNode == child)
                {
                    count++;
                }
            }
            
            return count;
        }
        
        foreach (Node childNode in _children)
        {
            if (childNode == child)
            {
                count++;
            }
            
            count += childNode.Count
        }
    }*/

    public int Count<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Node child, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(TNode child, int startIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Node child, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(TNode child, int startIndex, int count)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int CountInRange(Node child, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate, int startIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, bool> predicate, int startIndex, int count)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int CountInRange(Func<Node, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(Func<Node, bool> predicate, int startIndex, int endIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, int, bool> predicate, int startIndex)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate, int startIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int Count(Func<Node, int, bool> predicate, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public int Count<TNode>(Func<TNode, int, bool> predicate, int startIndex, int count)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int CountInRange(Func<Node, int, bool> predicate, int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public int CountInRange<TNode>(Func<Node, int, bool> predicate, int startIndex, int endIndex)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}