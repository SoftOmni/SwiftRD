using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public bool Contains(INode child)
    {
        return Contains(node => node == child);
    }

    public bool Contains(Node child)
    {
        return _children.Contains(child);
    }

    public bool Contains<TNode>(TNode child)
        where TNode : INode
    {
        return Contains(node => node.Equals(child));
    }

    public bool Contains(Node child, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains<TNode>(TNode child, int startIndex)
        where TNode : Node
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains(Node child, int startIndex, int count)
    {
        CheckIndexes(startIndex, count);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains<TNode>(TNode child, int startIndex, int count)
        where TNode : Node
    {
        CheckIndexes(startIndex, count);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool ContainsInRange(Node child, int startIndex, int endIndex)
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(child, startIndex, endIndex);
    }

    public bool ContainsInRange<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : Node
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(child, startIndex, endIndex);
    }

    private bool ContainsInRangeUnchecked(Node child, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            if (_children[i] == child)
            {
                return true;
            }
        }

        return false;
    }

    private bool ContainsInRangeUnchecked<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : Node
    {
        Node node = child;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (_children[i] == node)
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Func<Node, bool> predicate)
    {
        foreach (Node node in _children)
        {
            if (predicate(node))
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Func<Node, bool> predicate, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, _children.Count);
    }

    public bool Contains(Func<Node, bool> predicate, int startIndex, int count)
    {
        CheckIndexes(startIndex + count);
        return ContainsInRangeUnchecked(predicate, startIndex, startIndex + count);
    }

    public bool ContainsInRange(Func<Node, bool> predicate, int startIndex, int endIndex)
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, endIndex);
    }

    public bool Contains(Func<Node, int, bool> predicate)
    {
        return ContainsInRange(predicate, 0, _children.Count);
    }

    public bool Contains(Func<Node, int, bool> predicate, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, _children.Count);
    }

    public bool Contains(Func<Node, int, bool> predicate, int startIndex, int count)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, startIndex + count);
    }

    public bool ContainsInRange(Func<Node, int, bool> predicate, int startIndex, int endIndex)
    {
        CheckIndexes(startIndex, endIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, endIndex);
    }

    private bool ContainsInRangeUnchecked(Func<Node, bool> predicate, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            if (predicate(_children[i]))
            {
                return true;
            }
        }

        return false;
    }

    private bool ContainsInRangeUnchecked(Func<Node, int, bool> predicate, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            if (predicate(_children[i], i))
            {
                return true;
            }
        }

        return false;
    }
}