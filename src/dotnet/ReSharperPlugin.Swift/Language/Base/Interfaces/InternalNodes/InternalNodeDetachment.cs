using System;
using System.Collections.Generic;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Base;

public partial interface IInternalNode
{ 
    internal void DetachChild(int childIndex, Action<INode> onChildDetachment);

    public INode DetachChildAt(int index);

    internal INode DetachChildAt(int index, Action<INode> onChildDetachment);

    public void DetachChildAtAndDiscard(int index);

    internal INode DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(int index, int count);

    internal List<INode> DetachChildrenAt(int index, int count, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(int index, int count);

    internal void DetachChildrenAtAndDiscard(int index, int count, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex);

    internal List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex);

    internal void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes);

    internal List<INode> DetachChildrenAt(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes);

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IList<int> indexes);

    internal List<INode> DetachChildrenAt(IList<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IList<int> indexes);

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes);

    internal List<INode> DetachChildrenAt(List<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes);

    internal void DetachChildrenAtAndDiscard(List<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt<TList>(TList indexes) where TList : IList<int>;

    internal List<INode> DetachChildrenAt<TList>(TList indexes, Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes) where TList : IList<int>;

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, Action<INode> onChildDetachment) where TList : IList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    internal List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart) where TList : IList<int>;

    internal List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>;

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>;

    internal List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>;

    internal void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public bool DetachChild(INode child);

    public List<INode> DetachChildren(IEnumerable<INode> indexes);

    internal List<INode> DetachChildren(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes);

    internal void DetachChildrenAndDiscard(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes);

    internal List<INode> DetachChildren(IList<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes);

    internal void DetachChildrenAndDiscard(IList<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes);

    internal List<INode> DetachChildren(List<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes);

    internal void DetachChildrenAndDiscard(List<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public INode DetachChildAtForcibly(int index);

    internal INode DetachChildAtForcibly(int index, Action<INode> onChildDetachment);

    public void DetachChildAtAndDiscardForcibly(int index);

    internal INode DetachChildAtAndDiscardForcibly(int index, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(int index, int count);

    internal List<INode> DetachChildrenAtForcibly(int index, int count, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(int index, int count);

    internal void DetachChildrenAtAndDiscardForcibly(int index, int count, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRangeForcibly(int startIndex, int endIndex);

    internal List<INode> DetachChildrenAtWithRangeForcibly(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex);

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes);

    internal List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes);

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IList<int> indexes);

    internal List<INode> DetachChildrenAtForcibly(IList<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes);

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(List<int> indexes);

    internal List<INode> DetachChildrenAtForcibly(List<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes);

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly<TList>(TList indexes) where TList : IList<int>;

    internal List<INode> DetachChildrenAtForcibly<TList>(TList indexes, Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes) where TList : IList<int>;

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, Action<INode> onChildDetachment) where TList : IList<int>;

    public List<INode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    internal List<INode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public List<INode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>;

    internal List<INode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>;

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public List<INode> DetachChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>;

    internal List<INode> DetachChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void DetachChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>;

    internal void DetachChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public bool DetachChildForcibly(INode child);

    public List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes);

    internal List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes);

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRangeForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRangeForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscardForcibly(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(IList<INode> indexes);

    internal List<INode> DetachChildrenForcibly(IList<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IList<INode> indexes);

    internal void DetachChildrenAndDiscardForcibly(IList<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(IList<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenForcibly(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenForcibly(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRangeForcibly(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRangeForcibly(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscardForcibly(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(List<INode> indexes);

    internal List<INode> DetachChildrenForcibly(List<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(List<INode> indexes);

    internal void DetachChildrenAndDiscardForcibly(List<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(List<INode> indexes, int startIndexInEnumeration);

    internal List<INode> DetachChildrenForcibly(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration);

    internal void DetachChildrenAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenForcibly(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal List<INode> DetachChildrenForcibly(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart);

    internal void DetachChildrenAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRangeForcibly(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal List<INode> DetachChildrenWithRangeForcibly(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration);

    internal void DetachChildrenWithRangeAndDiscardForcibly(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    internal List<INode> DetachChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration) where TList : IList<TListElements> where TListElements : INode;

    internal void DetachChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    internal INode DetachChildForcibly(int childIndex)
    {
        if (childIndex < 0 || childIndex > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(childIndex));
        }

        int start = Children[childIndex].ParentTextIndex;
        int end = childIndex + 1 == Children.Count ? EditableBuffer.Length : Children[childIndex + 1].ParentTextIndex;

        IEditableBuffer newChildBuffer = EditableBufferExtensions.CloneBuffer(EditableBuffer, start, end);
        if (Children[childIndex] is SwiftInternalNode internalNode)
        {
            internalNode.EditableBuffer = newChildBuffer;
            internalNode.CoreParent = null;
        }
        else if (Children[childIndex] is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer = newChildBuffer;
            leafNode.CoreParent = null;
        }

        int length = end - start;
        newChildBuffer.Remove(start, length);

        INode removedChild = Children[childIndex];
        Children.RemoveAt(childIndex);

        for (int i = childIndex; i < Children.Count; i++)
        {
            INode child = Children[i];

            switch (child)
            {
                case SwiftInternalNode internalChild:
                    internalChild.ParentTextIndex -= length;
                    break;
                case SwiftLeafNode leafChild:
                    leafChild.ParentTextIndex -= length;
                    break;
            }
        }

        return removedChild;
    }

    internal void DetachChildForcibly(int childIndex, Action<INode> onChildDetachment)
    {
        INode detachedChild = DetachChildForcibly(childIndex);
        onChildDetachment(detachedChild);
    }

    public void DetachFromParent()
    {
        CoreParent?.DetachChild(ParentIndex);
    }

    internal void DetachFromParentForcibly()
    {
        CoreParent?.DetachChildForcibly(ParentIndex);
    }
}