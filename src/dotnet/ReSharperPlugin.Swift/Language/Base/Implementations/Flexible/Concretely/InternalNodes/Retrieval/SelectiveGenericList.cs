using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);
    
    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate)
    {
        List<INode> nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
    {
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate)
    {
        List<INode> nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate, Action<INode> onChildRetrieval)
    {
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate)
    {
        List<INode> nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
    {
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate)
    {
        List<Node> nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate, Action<Node> onChildRetrieval)
    {
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate)
    {
        List<Node> nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate, Action<Node> onChildRetrieval)
    {
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate)
    {
        List<Node> nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
    {
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate, int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public IList<INode> GetSelectiveNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<INode> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<INode> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<INode> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListType(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<Node> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<Node> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate, int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        List<Node> nodes = [];

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListType(Func<Node, int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        int target = startIndex + count;
        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public IList<INode> GetSelectiveNodesAsGenericListTypeOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
    
    public List<INode> GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<INode> GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<INode> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }


    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsGenericListTypeOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithLooseNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<Node, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
    
    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<Node, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
    
    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public List<Node> GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<Node, int, bool> predicate, int startIndex,
        int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        List<Node> nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
    
    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsGenericListTypeOverRange(Func<Node, int, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        ListWithConcreteNodesWithAction nodes = new(onChildRetrieval);

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
}