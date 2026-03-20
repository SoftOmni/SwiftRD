using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

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

    public Node GetConcreteChildAt(int index)
    {
        return _children[index];
    }

    public Node GetConcreteChildAt(int index, Action<Node> onChildRetrieval)
    {
        onChildRetrieval(_children[index]);
        return _children[index];
    }

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

    public ConcreteEnumerator GetConcreteChildEnumerator()
    {
        return new ConcreteEnumerator(this);
    }

    public ConcreteEnumeratorWithAction GetConcreteChildEnumerator(Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithAction(this, onChildRetrieval);
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

    public ConcreteEnumerator GetConcreteChildEnumerator(int startIndex)
    {
        return new ConcreteEnumerator(this, startIndex);
    }

    public ConcreteEnumeratorWithAction GetConcreteChildEnumerator(int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithAction(this, startIndex, onChildRetrieval);
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

    public IEnumerator<INode> GetConcreteChildEnumerator(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteEnumerator(this, startIndex, startIndex + count);
    }

    public IEnumerator<INode> GetConcreteChildEnumerator(int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteEnumeratorWithAction(this, startIndex, startIndex + count, onChildRetrieval);
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

    public IEnumerator<INode> GetConcreteChildEnumeratorOverRange(int startIndex, int endIndex)
    {
        return new ConcreteEnumerator(this, startIndex, endIndex);
    }

    public IEnumerator<INode> GetConcreteChildEnumeratorOverRange(int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithAction(this, startIndex, endIndex, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsEnumerable()
    {
        return new ConcreteReadOnlyList(this);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsEnumerable(Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsEnumerable(int startIndex)
    {
        return new ConcreteReadOnlyList(this, startIndex);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsEnumerable(int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, startIndex, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsEnumerable(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyList(this, startIndex, startIndex + count);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsEnumerable(int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithAction(this, startIndex, startIndex + count, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsEnumerableOverRange(int startIndex, int endIndex)
    {
        return new ConcreteReadOnlyList(this, startIndex, endIndex);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsEnumerableOverRange(int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, startIndex, endIndex, onChildRetrieval);
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

    public IReadOnlyList<Node> GetConcreteChildNodesAsGenericReadOnlyListType()
    {
        return _children;
    }

    public IReadOnlyList<Node> GetConcreteChildNodesAsGenericReadOnlyListType(Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsGenericReadOnlyListType(int startIndex)
    {
        return new ConcreteReadOnlyList(this, startIndex);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsGenericReadOnlyListType(int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, startIndex, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsGenericReadOnlyListType(int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyList(this, startIndex, startIndex + count);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsGenericReadOnlyListType(int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithAction(this, startIndex, startIndex + count, onChildRetrieval);
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

    public ConcreteReadOnlyList GetConcreteChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex)
    {
        return new ConcreteReadOnlyList(this, startIndex, endIndex);
    }

    public ConcreteReadOnlyListWithAction GetConcreteChildNodesAsGenericReadOnlyListTypeOverRange(int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithAction(this, startIndex, endIndex, onChildRetrieval);
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

    public IList<Node> GetConcreteChildNodesAsGenericListType()
    {
        return [.._children];
    }

    public ConcreteListWithAction GetConcreteChildNodesAsGenericListType(Action<Node> onChildRetrieval)
    {
        return new ConcreteListWithAction([.._children], onChildRetrieval);
    }

    public IList<INode> GetChildNodesAsGenericListType(int startIndex)
        => GetLooseChildNodesAsGenericListType(startIndex);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListType(startIndex, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex)
        => GetLooseChildNodesAsList(startIndex);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, onChildRetrieval);

    public IList<Node> GetConcreteChildNodesAsGenericListType(int startIndex)
        => GetConcreteChildNodesAsList(startIndex);

    public IList<Node> GetConcreteChildNodesAsGenericListType(int startIndex, Action<Node> onChildRetrieval)
        => GetConcreteChildNodesAsList(startIndex, onChildRetrieval);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, int count)
        => GetLooseChildNodesAsGenericListType(startIndex, count);

    public IList<INode> GetChildNodesAsGenericListType(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListType(startIndex, count, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, int count)
        => GetLooseChildNodesAsList(startIndex, count);

    public IList<INode> GetLooseChildNodesAsGenericListType(int startIndex, int count, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsList(startIndex, count, onChildRetrieval);

    public IList<Node> GetConcreteChildNodesAsGenericListType(int startIndex, int count)
        => GetConcreteChildNodesAsList(startIndex, count);

    public IList<Node> GetConcreteChildNodesAsGenericListType(int startIndex, int count, Action<Node> onChildRetrieval)
        => GetConcreteChildNodesAsList(startIndex, count, onChildRetrieval);

    public IList<INode> GetChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsGenericListTypeOverRange(startIndex, endIndex);

    public IList<INode> GetChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsGenericListTypeOverRange(startIndex, endIndex, onChildRetrieval);

    public IList<INode> GetLooseChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex);

    public IList<INode> GetLooseChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetLooseChildNodesAsListOverRange(startIndex, endIndex, onChildRetrieval);

    public IList<Node> GetConcreteChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex)
        => GetConcreteChildNodesAsListOverRange(startIndex, endIndex);

    public IList<Node> GetConcreteChildNodesAsGenericListTypeOverRange(int startIndex, int endIndex, Action<Node> onChildRetrieval)
        => GetConcreteChildNodesAsListOverRange(startIndex, endIndex, onChildRetrieval);

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

    public List<Node> GetConcreteChildNodesAsList()
    {
        return [.._children];
    }

    public ListWithConcreteNodesWithAction GetConcreteChildNodesAsList(Action<Node> onChildRetrieval)
    {
        return new ListWithConcreteNodesWithAction([.._children], onChildRetrieval);
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

    public List<Node> GetConcreteChildNodesAsList(int startIndex)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        int capacity = NumberOfChildren - startIndex;
        List<Node> nodes = new(capacity);

        for (int i = startIndex; i < NumberOfChildren; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetConcreteChildNodesAsList(int startIndex, Action<Node> onChildRetrieval)
    {
        return new ListWithConcreteNodesWithAction(GetConcreteChildNodesAsGenericReadOnlyListType(startIndex), onChildRetrieval);
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

    public List<Node> GetConcreteChildNodesAsList(int startIndex, int count)
    {
        if (startIndex < 0 || startIndex > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndex));
        }

        if (count < 0 || startIndex + count > NumberOfChildren)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        List<Node> nodes = new(count);

        int target = startIndex + count;
        for (int i = startIndex; i < target; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetConcreteChildNodesAsList(int startIndex, int count, Action<Node> onChildRetrieval)
    {
        return new ListWithConcreteNodesWithAction(GetConcreteChildNodesAsGenericReadOnlyListType(startIndex, count), onChildRetrieval);
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

    public List<Node> GetConcreteChildNodesAsListOverRange(int startIndex, int endIndex)
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
        List<Node> nodes = new(capacity);

        for (int i = startIndex; i < endIndex; i++)
        {
            nodes.Add(_children[i]);
        }

        return nodes;
    }

    public ListWithConcreteNodesWithAction GetConcreteChildNodesAsListOverRange(int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ListWithConcreteNodesWithAction(
            GetConcreteChildNodesAsGenericReadOnlyListTypeOverRange(startIndex, endIndex), onChildRetrieval);
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

    public TList GetConcreteChildNodesAsGenericListType<TList>()
        where TList : IList<Node>, new()
    {
        return [.._children];
    }

    public TList GetConcreteChildNodesAsGenericListType<TList>(Action<Node> onChildRetrieval)
        where TList : IList<Node>, IWithActionOnChildRetrievalConcrete, new()
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

    public TList GetConcreteChildNodesAsGenericListType<TList>(int startIndex)
        where TList : IList<Node>, new()
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

    public TList GetConcreteChildNodesAsGenericListType<TList>(int startIndex, Action<Node> onChildRetrieval)
        where TList : IList<Node>, IWithActionOnChildRetrievalConcrete, new()
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

    public TList GetConcreteChildNodesAsGenericListType<TList>(int startIndex, int count)
        where TList : IList<Node>, new()
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

    public TList GetConcreteChildNodesAsGenericListType<TList>(int startIndex, int count, Action<Node> onChildRetrieval)
        where TList : IList<Node>, IWithActionOnChildRetrievalConcrete, new()
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

    public TList GetConcreteChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex)
        where TList : IList<Node>, new()
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

    public TList GetConcreteChildNodesAsGenericListTypeOverRange<TList>(int startIndex, int endIndex, Action<Node> onChildRetrieval)
        where TList : IList<Node>, IWithActionOnChildRetrievalConcrete, new()
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