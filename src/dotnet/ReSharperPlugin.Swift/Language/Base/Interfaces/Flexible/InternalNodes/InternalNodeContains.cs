using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public bool Contains(INode child);

    public bool Contains<TNode>(TNode child) where TNode : INode;

    public bool Contains(INode child, int startIndex);

    public bool Contains<TNode>(TNode child, int startIndex) where TNode : INode;

    public bool Contains(INode child, int startIndex, int count);

    public bool Contains<TNode>(TNode child, int startIndex, int count) where TNode : INode;

    public bool ContainsInRange(INode child, int startIndex, int endIndex);

    public bool ContainsInRange<TNode>(TNode child, int startIndex, int endIndex) where TNode : INode;

    public bool Contains(Func<INode, bool> predicate);

    public bool Contains(Func<INode, bool> predicate, int startIndex);

    public bool Contains(Func<INode, bool> predicate, int startIndex, int count);

    public bool ContainsInRange(Func<INode, bool> predicate, int startIndex, int endIndex);
    
    public bool Contains(Func<INode, int, bool> predicate);

    public bool Contains(Func<INode, int, bool> predicate, int startIndex);

    public bool Contains(Func<INode, int, bool> predicate, int startIndex, int count);

    public bool ContainsInRange(Func<INode, int, bool> predicate, int startIndex, int endIndex);

    public bool ContainsAll(IEnumerator<INode> children, bool disposeEnumerator = true);

    public bool ContainsAll(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true);

    public bool ContainsAll(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsAllInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsAllOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAll(IEnumerable<INode> children);

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration);

    public bool ContainsAll(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration);

    public bool ContainsAllInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration);

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInChildren);

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren);

    public bool ContainsAllOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren);

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren);

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren); // TODO: review this naming scheme

    public bool ContainsAll(IList<INode> children);

    public bool ContainsAll(IList<INode> children, int startIndexInList);

    public bool ContainsAll(IList<INode> children, int startIndexInList, int countInList);

    public bool ContainsAllInRange(IList<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInChildren);

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsAllOverRange(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAllOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(IList<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRangeInRange(IList<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAll(List<INode> children);

    public bool ContainsAll(List<INode> children, int startIndexInList);

    public bool ContainsAll(List<INode> children, int startIndexInList, int countInList);

    public bool ContainsAllInRange(List<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsAllOverRange(List<INode> children, int startIndexInChildren);

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsAllOverRange(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAllOverRangeWithCount(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRange(List<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAllOverRangeWithRangeInRange(List<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAll<TList, TListElements>(TList children)
        where TList : IList<TListElements>;

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAll<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int countInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAllOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAll(Func<INode, bool> predicate);

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren);

    public bool ContainsAll(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsAllInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAll(Func<INode, int, bool> predicate);

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren);

    public bool ContainsAll(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsAllInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSome(IEnumerator<INode> children, bool disposeEnumerator = true);

    public bool ContainsSome(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true);

    public bool ContainsSome(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsSomeInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSomeOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsSome(IEnumerable<INode> children);

    public bool ContainsSome(IEnumerable<INode> children, int startIndexInEnumeration);

    public bool ContainsSome(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration);

    public bool ContainsSomeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInChildren);

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren);

    public bool ContainsSomeOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren);

    public bool ContainsSomeOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren);

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren,
        int countInChildren);

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren); // TODO: review this naming scheme

    public bool ContainsSome(IList<INode> children);

    public bool ContainsSome(IList<INode> children, int startIndexInList);

    public bool ContainsSome(IList<INode> children, int startIndexInList, int countInList);

    public bool ContainsSomeInRange(IList<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInChildren);

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsSomeOverRange(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsSomeOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsSomeOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(IList<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRangeInRange(IList<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSome(List<INode> children);

    public bool ContainsSome(List<INode> children, int startIndexInList);

    public bool ContainsSome(List<INode> children, int startIndexInList, int countInList);

    public bool ContainsSomeInRange(List<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInChildren);

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsSomeOverRange(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsSomeOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsSomeOverRangeWithCount(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRange(List<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSomeOverRangeWithRangeInRange(List<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSome<TList, TListElements>(TList children)
        where TList : IList<TListElements>;

    public bool ContainsSome<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSome<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int countInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSomeOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsSome(Func<INode, bool> predicate);

    public bool ContainsSome(Func<INode, bool> predicate, int startIndexInChildren);

    public bool ContainsSome(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsSomeInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsSome(Func<INode, int, bool> predicate);

    public bool ContainsSome(Func<INode, int, bool> predicate, int startIndexInChildren);

    public bool ContainsSome(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsSomeInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAny(IEnumerator<INode> children, bool disposeEnumerator = true);

    public bool ContainsAny(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true);

    public bool ContainsAny(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsAnyInRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsAnyOverRange(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAnyOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsAny(IEnumerable<INode> children);

    public bool ContainsAny(IEnumerable<INode> children, int startIndexInEnumeration);

    public bool ContainsAny(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration);

    public bool ContainsAnyInRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration);

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInChildren);

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren);

    public bool ContainsAnyOverRange(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration,
        int startIndexInChildren);

    public bool ContainsAnyOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren);

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren); // TODO: review this naming scheme

    public bool ContainsAny(IList<INode> children);

    public bool ContainsAny(IList<INode> children, int startIndexInList);

    public bool ContainsAny(IList<INode> children, int startIndexInList, int countInList);

    public bool ContainsAnyInRange(IList<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInChildren);

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsAnyOverRange(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsAnyOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAnyOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(IList<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRangeInRange(IList<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAny(List<INode> children);

    public bool ContainsAny(List<INode> children, int startIndexInList);

    public bool ContainsAny(List<INode> children, int startIndexInList, int countInList);

    public bool ContainsAnyInRange(List<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInChildren);

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsAnyOverRange(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsAnyOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsAnyOverRangeWithCount(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRange(List<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAnyOverRangeWithRangeInRange(List<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAny<TList, TListElements>(TList children)
        where TList : IList<TListElements>;

    public bool ContainsAny<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAny<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int countInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAnyOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsAny(Func<INode, bool> predicate);

    public bool ContainsAny(Func<INode, bool> predicate, int startIndexInChildren);

    public bool ContainsAny(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsAnyInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsAny(Func<INode, int, bool> predicate);

    public bool ContainsAny(Func<INode, int, bool> predicate, int startIndexInChildren);

    public bool ContainsAny(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsAnyInRange(Func<INode, int, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOf(IEnumerator<INode> children, bool disposeEnumerator = true);

    public bool ContainsNoneOf(IEnumerator<INode> children, int startIndexInEnumeration, bool disposeEnumerator = true);

    public bool ContainsNoneOf(IEnumerator<INode> children, int startIndexInEnumeration, int countInEnumeration,
        bool disposeEnumerator = true);

    public bool ContainsNoneOfInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInChildren,
        bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInChildren,
        int countInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInChildren,
        int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOfOverRangeWithRangeInRange(IEnumerator<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren, bool disposeEnumerator = true);

    public bool ContainsNoneOf(IEnumerable<INode> children);

    public bool ContainsNoneOf(IEnumerable<INode> children, int startIndexInEnumeration);

    public bool ContainsNoneOf(IEnumerable<INode> children, int startIndexInEnumeration, int countInEnumeration);

    public bool ContainsNoneOfInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInChildren);

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren);

    public bool ContainsNoneOfOverRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren);

    public bool ContainsNoneOfOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInChildren,
        int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int countInEnumeration,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRangeInRange(IEnumerable<INode> children, int startIndexInEnumeration,
        int endIndexInEnumeration,
        int startIndexInChildren, int endIndexInChildren); // TODO: review this naming scheme

    public bool ContainsNoneOf(IList<INode> children);

    public bool ContainsNoneOf(IList<INode> children, int startIndexInList);

    public bool ContainsNoneOf(IList<INode> children, int startIndexInList, int countInList);

    public bool ContainsNoneOfInRange(IList<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInChildren);

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsNoneOfOverRange(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsNoneOfOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(IList<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeInRange(IList<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(IList<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRangeInRange(IList<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOf(List<INode> children);

    public bool ContainsNoneOf(List<INode> children, int startIndexInList);

    public bool ContainsNoneOf(List<INode> children, int startIndexInList, int countInList);

    public bool ContainsNoneOfInRange(List<INode> children, int startIndexInList, int endIndexInList);

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInChildren);

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInList, int startIndexInChildren);

    public bool ContainsNoneOfOverRange(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren);

    public bool ContainsNoneOfOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren);

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInList, int startIndexInChildren,
        int countInChildren);

    public bool ContainsNoneOfOverRangeWithCount(List<INode> children, int startIndexInList, int countInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeInRange(List<INode> children, int startIndexInList, int endIndexInList,
        int startIndexInChildren, int countInChildren);

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInChildren,
        int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRange(List<INode> children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOfOverRangeWithRangeInRange(List<INode> children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOf<TList, TListElements>(TList children)
        where TList : IList<TListElements>;

    public bool ContainsNoneOf<TList, TListElements>(TList children, int startIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOf<TList, TListElements>(TList children, int startIndexInList, int countInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfInRange<TList, TListElements>(TList children, int startIndexInList, int endIndexInList)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRange<TList, TListElements>(TList children, int startIndexInList, int countInList,
        int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInChildren,
        int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithCount<TList, TListElements>(TList children, int startIndexInList,
        int countInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList, int startIndexInChildren, int countInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInChildren,
        int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithRange<TList, TListElements>(TList children, int startIndexInList,
        int countInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOfOverRangeWithRangeInRange<TList, TListElements>(TList children, int startIndexInList,
        int endIndexInList,
        int startIndexInChildren, int endIndexInChildren)
        where TList : IList<TListElements> where TListElements : INode;

    public bool ContainsNoneOf(Func<INode, bool> predicate);

    public bool ContainsNoneOf(Func<INode, bool> predicate, int startIndexInChildren);

    public bool ContainsNoneOf(Func<INode, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsNoneOfInRange(Func<INode, bool> predicate, int startIndexInChildren, int endIndexInChildren);

    public bool ContainsNoneOf(Func<INode, int, bool> predicate);

    public bool ContainsNoneOf(Func<INode, int, bool> predicate, int startIndexInChildren);

    public bool ContainsNoneOf(Func<INode, int, bool> predicate, int startIndexInChildren, int countIndexInChildren);

    public bool ContainsNoneOfInRange(Func<INode, int, bool> predicate, int startIndexInChildren,
        int endIndexInChildren);
}