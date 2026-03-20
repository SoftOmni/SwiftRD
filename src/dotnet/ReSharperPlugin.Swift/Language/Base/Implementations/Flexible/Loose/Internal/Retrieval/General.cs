using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public INode GetChildAt(int index)
    {
        return _children[index];
    }

    public INode GetChildAt(int index, Action<INode> onChildRetrieval)
    {
        onChildRetrieval(_children[index]);
        return _children[index];
    }

    public INode GetLooseChildAt(int index)
        => GetChildAt(index);

    public INode GetLooseChildAt(int index, Action<INode> onChildRetrieval)
        => GetChildAt(index, onChildRetrieval);

    public IEnumerator<INode> GetChildEnumerator()
    {
        return new LooseEnumerator(this);
    }

    public IEnumerator<INode> GetChildEnumerator(Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, onChildRetrieval);
    }

    public LooseEnumerator GetLooseChildEnumerator()
    {
        return new LooseEnumerator(this);
    }

    public LooseEnumeratorWithAction GetLooseChildEnumerator(Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, onChildRetrieval);
    }

    public IEnumerator<INode> GetChildEnumerator(int startIndex)
    {
        return new LooseEnumerator(this, startIndex);
    }

    public IEnumerator<INode> GetChildEnumerator(int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, startIndex, onChildRetrieval);
    }

    public LooseEnumerator GetLooseChildEnumerator(int startIndex)
    {
        return new LooseEnumerator(this, startIndex);
    }

    public LooseEnumeratorWithAction GetLooseChildEnumerator(int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, startIndex, onChildRetrieval);
    }

    public IEnumerator<INode> GetChildEnumerator(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseEnumerator(this, startIndex, startIndex + count);
    }

    public IEnumerator<INode> GetChildEnumerator(int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseEnumeratorWithAction(this, startIndex, startIndex + count, onChildRetrieval);
    }

    public IEnumerator<INode> GetLooseChildEnumerator(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseEnumerator(this, startIndex, startIndex + count);
    }

    public IEnumerator<INode> GetLooseChildEnumerator(int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseEnumeratorWithAction(this, startIndex, startIndex + count, onChildRetrieval);
    }

    public IEnumerator<INode> GetChildEnumeratorOverRange(int startIndex, int endIndex)
    {
        return new LooseEnumerator(this, startIndex, endIndex);
    }

    public IEnumerator<INode> GetChildEnumeratorOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, startIndex, endIndex, onChildRetrieval);
    }

    public IEnumerator<INode> GetLooseChildEnumeratorOverRange(int startIndex, int endIndex)
    {
        return new LooseEnumerator(this, startIndex, endIndex);
    }

    public IEnumerator<INode> GetLooseChildEnumeratorOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithAction(this, startIndex, endIndex, onChildRetrieval);
    }

    public IEnumerable<INode> GetChildNodesAsEnumerable()
    {
        return _children;
    }

    public IEnumerable<INode> GetChildNodesAsEnumerable(Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, onChildRetrieval);
    }

    public LooseReadOnlyList GetLooseNodesAsEnumerable()
    {
        return new LooseReadOnlyList(this);
    }

    public LooseReadOnlyListWithAction GetLooseNodesAsEnumerable(Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, onChildRetrieval);
    }

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex)
        => GetLooseChildNodesAsEnumerable(startIndex);

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsEnumerable(startIndex, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsEnumerable(int startIndex)
    {
        return new LooseReadOnlyList(this, startIndex);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsEnumerable(int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, startIndex, onChildRetrieval);
    }

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex, int count)
        => GetLooseChildNodesAsEnumerable(startIndex, count);

    public IEnumerable<INode> GetChildNodesAsEnumerable(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsEnumerable(startIndex, count, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsEnumerable(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseReadOnlyList(this, startIndex, startIndex + count);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsEnumerable(int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseReadOnlyListWithAction(this, startIndex, startIndex + count, onChildRetrieval);
    }

    public IEnumerable<INode> GetChildNodesAsEnumerableOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsEnumerableOverRange(startIndex, endIndex);

    public IEnumerable<INode> GetChildNodesAsEnumerableOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsEnumerableOverRange(startIndex, endIndex, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsEnumerableOverRange(int startIndex, int endIndex)
    {
        return new LooseReadOnlyList(this, startIndex, endIndex);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsEnumerableOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, startIndex, endIndex, onChildRetrieval);
    }

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType()
    {
        return _children;
    }

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, onChildRetrieval);
    }

    public IReadOnlyList<INode> GetLooseChildNodesAsGenericReadOnlyListType()
    {
        return _children;
    }

    public IReadOnlyList<INode> GetLooseChildNodesAsGenericReadOnlyListType(Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, onChildRetrieval);
    }

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex)
        => GetLooseChildNodesAsGenericReadOnlyListType(startIndex);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericReadOnlyListType(startIndex, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsGenericReadOnlyListType(int startIndex)
    {
        return new LooseReadOnlyList(this, startIndex);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsGenericReadOnlyListType(int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, startIndex, onChildRetrieval);
    }

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex, int count)
        => GetLooseChildNodesAsGenericReadOnlyListType(startIndex, count);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListType(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericReadOnlyListType(startIndex, count, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsGenericReadOnlyListType(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseReadOnlyList(this, startIndex, startIndex + count);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsGenericReadOnlyListType(int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new LooseReadOnlyListWithAction(this, startIndex, startIndex + count, onChildRetrieval);
    }

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsGenericReadOnlyListTypeOverRange(startIndex, endIndex);

    public IReadOnlyList<INode> GetChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericReadOnlyListTypeOverRange(startIndex, endIndex, onChildRetrieval);

    public LooseReadOnlyList GetLooseChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex)
    {
        return new LooseReadOnlyList(this, startIndex, endIndex);
    }

    public LooseReadOnlyListWithAction GetLooseChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithAction(this, startIndex, endIndex, onChildRetrieval);
    }

    public IList<INode> GetChildNodesAsGenericListType()
        => GetLooseChildNodesAsGenericListType();

    public IList<INode> GetChildNodesAsGenericListType(Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListType(onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListType()
    {
        return [.._children];
    }

    public LooseListWithAction GetLooseChildNodesAsGenericListType(Action<INode> onChildRetrieval)
    {
        return new LooseListWithAction([.._children], onChildRetrieval);
    }

    public IList<INode> GetChildNodesAsGenericListType(int startIndex)
        => GetLooseChildNodesAsGenericListType(startIndex);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListType(startIndex, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex)
        => GetLooseChildNodesAsList(startIndex);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, onChildRetrieval);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, int count)
        => GetLooseChildNodesAsGenericListType(startIndex, count);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListType(startIndex, count, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, int count)
        => GetLooseChildNodesAsList(startIndex, count);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, count, onChildRetrieval);

    public IList<INode> GetChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsGenericListTypeOverRange(startIndex, endIndex);

    public IList<INode> GetChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListTypeOverRange(startIndex, endIndex, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex);

    public IList<INode> GetLooseChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex, onChildRetrieval);

    public List<INode> GetChildNodesAsList()
        => GetLooseChildNodesAsList();

    public List<INode> GetChildNodesAsList(Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(onChildRetrieval);

    public List<INode> GetLooseChildNodesAsList()
    {
        return [.._children];
    }

    public ListWithLooseNodesWithAction GetLooseChildNodesAsList(Action<INode> onChildRetrieval)
    {
        return new ListWithLooseNodesWithAction([.._children], onChildRetrieval);
    }
    
    public List<INode> GetChildNodesAsList(int startIndex)
        => GetLooseChildNodesAsList(startIndex);

    public List<INode> GetChildNodesAsList(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, onChildRetrieval);

    public List<INode> GetLooseChildNodesAsList(int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int capacity = NumberOfChildren - startIndex;
        List<INode> nodes = new(capacity);

        for (int i = startIndex; i < NumberOfChildren; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetLooseChildNodesAsList(int startIndex, Action<INode> onChildRetrieval)
    {
        return new ListWithLooseNodesWithAction(GetLooseChildNodesAsGenericReadOnlyListType(startIndex), onChildRetrieval);
    }

    public List<INode> GetChildNodesAsList(int startIndex, int count)
        => GetLooseChildNodesAsList(startIndex, count);

    public ListWithLooseNodesWithAction GetChildNodesAsList(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, count, onChildRetrieval);

    public List<INode> GetLooseChildNodesAsList(int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int capacity = NumberOfChildren - startIndex;
        List<INode> nodes = new(capacity);

        int target = startIndex + count;
        for (int i = startIndex; i < target; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetLooseChildNodesAsList(int startIndex, int count, Action<INode> onChildRetrieval)
    {
        return new ListWithLooseNodesWithAction(GetLooseChildNodesAsGenericReadOnlyListType(startIndex, count), onChildRetrieval);
    }

    public List<INode> GetChildNodesAsListOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex);

    public ListWithLooseNodesWithAction GetChildNodesAsListOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex, onChildRetrieval);

    public List<INode> GetLooseChildNodesAsListOverRange(int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (endIndex < startIndex || endIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndex));
        }

        int capacity = endIndex - startIndex;
        List<INode> nodes = new(capacity);

        for (int i = startIndex; i < endIndex; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithLooseNodesWithAction GetLooseChildNodesAsListOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new ListWithLooseNodesWithAction(GetLooseChildNodesAsGenericReadOnlyListTypeOverRange(startIndex, endIndex), onChildRetrieval);
    }

    public TList GetChildNodesAsGenericListType<TList>()
        where TList : IList<INode>, new()
        => GetLooseChildNodesAsGenericListType<TList>();

    public TList GetChildNodesAsGenericListType<TList>(Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
        => GetLooseChildNodesAsGenericListType<TList>(onChildRetrieval);

    public TList GetLooseChildNodesAsGenericListType<TList>()
        where TList : IList<INode>, new()
    {
        return [.._children];
    }

    public TList GetLooseChildNodesAsGenericListType<TList>(Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        TList newList = [.._children];
        newList.SetChildRetrievalAction(onChildRetrieval);

        return newList;
    }

    public TList GetChildNodesAsGenericListType<TList>(int startIndex)
        where TList : IList<INode>, new()
        => GetLooseChildNodesAsGenericListType<TList>(startIndex);

    public TList GetChildNodesAsGenericListType<TList>(int startIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
        => GetLooseChildNodesAsGenericListType<TList>(startIndex, onChildRetrieval);

    public TList GetLooseChildNodesAsGenericListType<TList>(int startIndex)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        TList newList = [];
        for (int i = startIndex; i < NumberOfChildren; i++)
        {
            newList.Add(_children[i]);
        }

        return newList;
    }

    public TList GetLooseChildNodesAsGenericListType<TList>(int startIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        TList newList = [];
        for (int i = startIndex; i < NumberOfChildren; i++)
        {
            newList.Add(_children[i]);
        }

        newList.SetChildRetrievalAction(onChildRetrieval);
        return newList;
    }

    public TList GetChildNodesAsGenericListType<TList>(int startIndex, int count)
        where TList : IList<INode>, new()
        => GetLooseChildNodesAsGenericListType<TList>(startIndex, count);

    public TList GetChildNodesAsGenericListType<TList>(int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
        => GetLooseChildNodesAsGenericListType<TList>(startIndex, count, onChildRetrieval);

    public TList GetLooseChildNodesAsGenericListType<TList>(int startIndex, int count)
        where TList : IList<INode>, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        TList newList = [];
        int target = startIndex + count;
        for (int i = startIndex; i < target; i++)
        {
            newList.Add(_children[i]);
        }

        return newList;
    }

    public TList GetLooseChildNodesAsGenericListType<TList>(int startIndex, int count, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        TList newList = [];
        int target = startIndex + count;
        for (int i = startIndex; i < target; i++)
        {
            newList.Add(_children[i]);
        }

        newList.SetChildRetrievalAction(onChildRetrieval);
        return newList;
    }

    public TList GetChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex)
        where TList : IList<INode>, new()
        => GetLooseChildNodesAsGenericListTypeOverRange<TList>(startIndex, endIndex);

    public TList GetChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        where TList : IList<INode>, IWithActionOnChildRetrievalLoose, new()
        => GetLooseChildNodesAsGenericListTypeOverRange<TList>(startIndex, endIndex, onChildRetrieval);

    public TList GetLooseChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex)
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

        TList newList = [];
        for (int i = startIndex; i < endIndex; i++)
        {
            newList.Add(_children[i]);
        }

        return newList;
    }

    public TList GetLooseChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex, Action<INode> onChildRetrieval)
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

        TList newList = [];
        for (int i = startIndex; i < endIndex; i++)
        {
            newList.Add(_children[i]);
        }

        newList.SetChildRetrievalAction(onChildRetrieval);
        return newList;
    }
}