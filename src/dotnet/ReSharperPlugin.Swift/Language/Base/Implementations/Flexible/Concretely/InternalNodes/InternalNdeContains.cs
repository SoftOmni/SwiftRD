using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

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

    public bool ContainsAll(IEnumerator<INode> children, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren, int countInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren, int endIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IList<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(IList<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(IList<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(List<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(List<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(List<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll<TList, TListElements>(TList children)
        where TList : IList<TListElements>
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAllInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerator<INode> children, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren, int countInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren, int endIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IList<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(IList<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(IList<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(List<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(List<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(List<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome<TList, TListElements>(TList children)
        where TList : IList<TListElements>
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, int, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSome(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsSomeInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerator<INode> children, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren, int countInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren, int endIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IList<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(IList<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(IList<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(List<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(List<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(List<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny<TList, TListElements>(TList children)
        where TList : IList<TListElements>
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, int, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAny(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsAnyInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerator<INode> children, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren, int countInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren, int endIndexInChildren,
        bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IList<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(IList<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(IList<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(List<INode> children, int startIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(List<INode> children, int startIndexInList, int countInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(List<INode> children, int startIndexInList, int endIndexInList)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList, int startIndexInChildren,
        int countInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInList, int countInList, int startIndexInChildren,
        int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf<TList, TListElements>(TList children)
        where TList : IList<TListElements>
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, int, bool> predicate, int startIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOf(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNoneOfInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren)
    {
        throw new NotImplementedException();
    }
}