using System;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public bool Contains(INode child)
    {
        return _children.Contains(child);
    }

    public bool Contains<TNode>(TNode child)
        where TNode : INode
    {
        return _children.Contains(child);
    }

    public bool Contains(INode child, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains<TNode>(TNode child, int startIndex)
        where TNode : INode
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains(INode child, int startIndex, int count)
    {
        CheckIndexes(startIndex, count);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool Contains<TNode>(TNode child, int startIndex, int count)
        where TNode : INode
    {
        CheckIndexes(startIndex, count);
        return ContainsInRangeUnchecked(child, startIndex, _children.Count);
    }

    public bool ContainsInRange(INode child, int startIndex, int endIndex)
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(child, startIndex, endIndex);
    }

    public bool ContainsInRange<TNode>(TNode child, int startIndex, int endIndex)
        where TNode : INode
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(child, startIndex, endIndex);
    }

    private bool ContainsInRangeUnchecked(INode child, int startIndex, int endIndex)
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
        where TNode : INode
    {
        INode node = child;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (_children[i] == node)
            {
                return true;
            }
        }

        return false;
    }

    public bool Contains(Func<INode, bool> predicate)
    {
        foreach (INode node in _children)
        {
            if (predicate(node))
            {
                return true;
            }
        }
        
        return false;
    }

    public bool Contains(Func<INode, bool> predicate, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, _children.Count);
    }

    public bool Contains(Func<INode, bool> predicate, int startIndex, int count)
    {
        CheckIndexes(startIndex + count);
        return ContainsInRangeUnchecked(predicate, startIndex, startIndex + count);
    }

    public bool ContainsInRange(Func<INode, bool> predicate, int startIndex, int endIndex)
    {
        CheckIndexesInRange(startIndex, endIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, endIndex);
    }

    public bool Contains(Func<INode, int, bool> predicate)
    {
        return ContainsInRange(predicate, 0, _children.Count);
    }
    
    public bool Contains(Func<INode, int, bool> predicate, int startIndex)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, _children.Count);
    }

    public bool Contains(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        CheckIndexes(startIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, startIndex + count);
    }

    public bool ContainsInRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
    {
        CheckIndexes(startIndex, endIndex);
        return ContainsInRangeUnchecked(predicate, startIndex, endIndex);
    }

    private bool ContainsInRangeUnchecked(Func<INode, bool> predicate, int startIndex, int endIndex)
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

    private bool ContainsInRangeUnchecked(Func<INode, int, bool> predicate, int startIndex, int endIndex)
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