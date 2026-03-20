using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate)
        where TList : IList<INode>, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate)
        where TList : IList<INode>, new()
    {
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate)
        where TList : IList<INode>, new()
    {
        TList nodes = [];

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
    

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
    
    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate)
        where TList : List<INode>, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }
        
        return nodes;
    }
    
    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
    
    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate)
        where TList : List<INode>, new()
    {
        TList nodes = [];

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
    
    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate)
        where TList : List<INode>, new()
    {
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
    
    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, bool> predicate)
        where TList : List<Node>, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        return nodes;
    }
    
    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, bool> predicate, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        TList nodes = [];

        foreach (Node child in _children)
        {
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
    
    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate)
        where TList : List<Node>, new()
    {
        TList nodes = [];

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
    
    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, int, bool> predicate)
        where TList : List<Node>, new()
    {
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        TList nodes = [];

        for (int index = 0; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, bool> predicate, int startIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, int, bool> predicate, int startIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<Node, int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < _children.Count; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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
    
    public TList GetSelectiveNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListType<TList>(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int target = startIndex + count;
        if (count < 0 || target > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < target; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<INode, bool> predicate, int startIndex,
        int endIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveNodesAsGenericListTypeOverRange<TList>(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<INode, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveLooseNodesAsGenericListTypeOverRange<TList>(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : List<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<Node, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<Node, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<Node, int, bool> predicate, int startIndex,
        int endIndex)
        where TList : List<Node>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

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

    public TList GetSelectiveConcreteNodesAsGenericListTypeOverRange<TList>(Func<Node, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        where TList : List<Node>, IWithActionOnChildRetrievalConcrete, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }
        
        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }
        
        TList nodes = [];

        for (int index = startIndex; index < endIndex; index++)
        {
            Node child = _children[index];
            if (predicate(child, index))
            {
                nodes.Add(child);
            }
        }

        nodes.SetChildRetrievalAction(onChildRetrieval);
        return nodes;
    }
}
