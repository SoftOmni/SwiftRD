using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public bool ContainsAll(IEnumerator<INode> nodesEnumerator, bool disposeEnumerator = true)
    {
        HashSet<INode> nodes = GatherNodes(nodesEnumerator, disposeEnumerator);

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, bool disposeEnumerator = true)
    {
        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, disposeEnumerator);

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int countInEnumeration, bool disposeEnumerator = true)
    {
        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration, disposeEnumerator);

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllInRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true)
    {
        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, endIndexInEnumeration, disposeEnumerator);

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerator<INode> nodesEnumerator, int startIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, _children.Count);
    }

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, endIndexInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> nodesEnumerator, int startIndexInChildren, int countInChildren,
        bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration + countInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, endIndexInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> nodesEnumerator, int startIndexInChildren, int endIndexInChildren,
        bool disposeEnumerator = true)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(nodesEnumerator, startIndexInEnumeration, endIndexInEnumeration, disposeEnumerator);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    private static HashSet<INode> GatherNodes(IEnumerator<INode> nodesEnumerator, bool disposeEnumerator)
    {
        HashSet<INode> nodes = [];

        while (nodesEnumerator.MoveNext())
        {
            nodes.Add(nodesEnumerator.Current);
        }

        return nodes;
    }

    private static HashSet<INode> GatherNodes(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, bool disposeEnumerator)
    {
        HashSet<INode> nodes = [];

        int index = 0;
        bool hadMoreElements = nodesEnumerator.MoveNext();
        while (hadMoreElements && index < startIndexInEnumeration)
        {
            hadMoreElements = nodesEnumerator.MoveNext();
            index += 1;
        }

        if (!hadMoreElements)
        {
            if (disposeEnumerator)
            {
                nodesEnumerator.Dispose();
            }

            if (index == startIndexInEnumeration)
            {
                return nodes;
            }

            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        nodes.Add(nodesEnumerator.Current);
        while (nodesEnumerator.MoveNext())
        {
            nodes.Add(nodesEnumerator.Current);
            index += 1;
        }

        if (disposeEnumerator)
        {
            nodesEnumerator.Dispose();
        }

        return nodes;
    }

    private static HashSet<INode> GatherNodes(IEnumerator<INode> nodesEnumerator, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator)
    {
        if (endIndexInEnumeration < startIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        if (endIndexInEnumeration == startIndexInEnumeration)
        {
            return [];
        }

        HashSet<INode> nodes = [];

        int index = 0;
        bool hadMoreElements = nodesEnumerator.MoveNext();
        while (hadMoreElements && index < startIndexInEnumeration)
        {
            hadMoreElements = nodesEnumerator.MoveNext();
            index += 1;
        }

        if (!hadMoreElements)
        {
            if (disposeEnumerator)
            {
                nodesEnumerator.Dispose();
            }

            if (index == startIndexInEnumeration)
            {
                return nodes;
            }

            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        nodes.Add(nodesEnumerator.Current);
        while (nodesEnumerator.MoveNext() && index < endIndexInEnumeration)
        {
            nodes.Add(nodesEnumerator.Current);
            index += 1;
        }

        if (disposeEnumerator)
        {
            nodesEnumerator.Dispose();
        }

        return nodes;
    }

    public bool ContainsAll(IEnumerable<INode> children)
    {
        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration);
        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration)
    {
        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration);
        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, endIndexInEnumeration);
        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, endIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, NumberOfChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, endIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, startIndexInEnumeration + countInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInEnumeration, endIndexInEnumeration);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    private HashSet<INode> GatherNodes(IEnumerable<INode> children)
    {
        HashSet<INode> nodes = [];

        foreach (INode node in children)
        {
            nodes.Add(node);
        }

        return nodes;
    }

    private HashSet<INode> GatherNodes(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        return GatherNodes(children.GetEnumerator(), startIndexInEnumeration, true);
    }

    private HashSet<INode> GatherNodes(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        return GatherNodes(children.GetEnumerator(), startIndexInEnumeration, endIndexInEnumeration, true);
    }

    public bool ContainsAll(IList<INode> children)
    {
        HashSet<INode> nodes = GatherNodes(children);

        return ContainsAll(nodes);
    }

    public bool ContainsAll(IList<INode> children, int startIndexInList)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);

        return ContainsAllUnchecked(nodes, 0, children.Count);
    }

    public bool ContainsAll(IList<INode> children, int startIndexInList, int countInList)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);

        return ContainsAllUnchecked(nodes, 0, nodes.Count);
    }

    public bool ContainsAllInRange(IList<INode> children, int startIndexInList, int endIndexInList)
    {
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);

        return ContainsAllUnchecked(nodes, 0, nodes.Count);
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    private static HashSet<INode> GatherNodes<TList>(TList nodesList)
        where TList : IList<INode>
    {
        HashSet<INode> nodes = [];

        foreach (INode node in nodesList)
        {
            nodes.Add(node);
        }

        return nodes;
    }

    private static HashSet<INode> GatherNodes<TList>(TList nodesList, int startIndexInEnumeration)
        where TList : IList<INode>
    {
        if (startIndexInEnumeration < 0 || startIndexInEnumeration >= nodesList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        HashSet<INode> nodes = [];

        for (int i = startIndexInEnumeration; i < nodesList.Count; i++)
        {
            nodes.Add(nodesList[i]);
        }

        return nodes;
    }

    private static HashSet<INode> GatherNodes<TList>(TList nodesList, int startIndexInEnumeration, int countInEnumeration)
        where TList : IList<INode>
    {
        if (startIndexInEnumeration < 0 || startIndexInEnumeration >= nodesList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        if (countInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        if (startIndexInEnumeration + countInEnumeration > nodesList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(countInEnumeration));
        }

        HashSet<INode> nodes = [];

        for (int i = startIndexInEnumeration; i < startIndexInEnumeration + countInEnumeration; i++)
        {
            nodes.Add(nodesList[i]);
        }

        return nodes;
    }

    private static HashSet<INode> GatherNodesInRange<TList>(TList nodesList, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<INode>
    {
        if (startIndexInEnumeration < 0 || startIndexInEnumeration >= nodesList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        if (endIndexInEnumeration < startIndexInEnumeration || endIndexInEnumeration > nodesList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        HashSet<INode> nodes = [];

        for (int i = startIndexInEnumeration; i < endIndexInEnumeration; i++)
        {
            nodes.Add(nodesList[i]);
        }

        return nodes;
    }

    public bool ContainsAll(List<INode> children)
    {
        HashSet<INode> nodes = GatherNodes(children);

        return ContainsAll(nodes);
    }

    public bool ContainsAll(List<INode> children, int startIndexInList)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);

        return ContainsAllUnchecked(nodes, 0, children.Count);
    }

    public bool ContainsAll(List<INode> children, int startIndexInList, int countInList)
    {
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);

        return ContainsAllUnchecked(nodes, 0, nodes.Count);
    }

    public bool ContainsAllInRange(List<INode> children, int startIndexInList, int endIndexInList)
    {
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);

        return ContainsAllUnchecked(nodes, 0, nodes.Count);
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, nodes.Count);
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        CheckIndexes(startIndexInChildren, countInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, startIndexInChildren + countInChildren);
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodes(children, startIndexInList, countInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);
        
        HashSet<INode> nodes = GatherNodesInRange(children, startIndexInList, endIndexInList);
        return ContainsAllUnchecked(nodes, startIndexInChildren, endIndexInChildren);
    }

    private bool ContainsAllUnchecked(HashSet<INode> nodes, int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            if (!nodes.Contains(_children[i]))
            {
                return false;
            }
        }

        return true;
    }

    public bool ContainsAll<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAll(children.Cast<INode>());
    }

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAll(children.Cast<INode>(), startIndexInList);
    }

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAll(children.Cast<INode>(), startIndexInList, countInList);
    }

    public bool ContainsAllInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllInRange(children.Cast<INode>(), startIndexInList, endIndexInList);
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRange(children.Cast<INode>(), startIndexInChildren);
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRange(children.Cast<INode>(), startIndexInList, startIndexInChildren);
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRange(children.Cast<INode>(), startIndexInList, countInList, startIndexInChildren);
    }

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeInRange(children.Cast<INode>(), startIndexInList, endIndexInList, startIndexInChildren);
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithCount(children.Cast<INode>(), startIndexInChildren, countInChildren);
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithCount(children.Cast<INode>(), startIndexInList, startIndexInChildren, countInChildren);
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithCount(children.Cast<INode>(), startIndexInList, countInList, startIndexInChildren, countInChildren);
    }

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeInRange(children.Cast<INode>(), startIndexInList, endIndexInList, startIndexInChildren, countInChildren);
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithRange(children.Cast<INode>(), startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithRange(children.Cast<INode>(), startIndexInList, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithRange(children.Cast<INode>(), startIndexInList, countInList, startIndexInChildren, endIndexInChildren);
    }

    public bool ContainsAllOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        return ContainsAllOverRangeWithRangeInRange(children.Cast<INode>(), startIndexInList, endIndexInList, startIndexInChildren,
            endIndexInChildren);
    }

    public bool ContainsAll(Func<INode, bool> predicate)
    {
        HashSet<INode> nodes = [];

        for (int i = 0; i < NumberOfChildren; i++)
        {
            if (predicate(_children[i]))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = [];

        for (int i = startIndexInChildren; i < NumberOfChildren; i++)
        {
            if (predicate(_children[i]))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        CheckIndexes(startIndexInChildren, countIndexInChildren);

        HashSet<INode> nodes = [];

        int endIndex = startIndexInChildren + countIndexInChildren;
        for (int i = startIndexInChildren; i < endIndex; i++)
        {
            if (predicate(_children[i]))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = [];

        for (int i = startIndexInChildren; i < endIndexInChildren; i++)
        {
            if (predicate(_children[i]))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(Func<INode, int, bool> predicate)
    {
        HashSet<INode> nodes = [];

        for (int i = 0; i < NumberOfChildren; i++)
        {
            if (predicate(_children[i], i))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren)
    {
        CheckIndexes(startIndexInChildren);

        HashSet<INode> nodes = [];

        for (int i = startIndexInChildren; i < NumberOfChildren; i++)
        {
            if (predicate(_children[i], i))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        CheckIndexes(startIndexInChildren, countIndexInChildren);

        HashSet<INode> nodes = [];

        int endIndex = startIndexInChildren + countIndexInChildren;
        for (int i = startIndexInChildren; i < endIndex; i++)
        {
            if (predicate(_children[i], i))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }

    public bool ContainsAllInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        CheckIndexesInRange(startIndexInChildren, endIndexInChildren);

        HashSet<INode> nodes = [];

        for (int i = startIndexInChildren; i < endIndexInChildren; i++)
        {
            if (predicate(_children[i], i))
            {
                nodes.Add(_children[i]);
            }
        }

        return ContainsAllUnchecked(nodes, 0, NumberOfChildren);
    }
}