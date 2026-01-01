using System;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    public virtual ISwiftNode DetachChild(int childIndex)
    {
        return DetachChildForcibly(childIndex);
    }

    internal void DetachChild(int childIndex, Action<ISwiftNode> onChildDetachment)
    {
        ISwiftNode detachedChild = DetachChild(childIndex);
        onChildDetachment(detachedChild);
    }

    public virtual ISwiftNode DetachChildAt(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode DetachChildAt(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode DetachChildAtAndDiscard(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool DetachChild(ISwiftNode child)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRange(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRange(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRange(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRange(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRange(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRange(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public ISwiftNode DetachChildAtForcibly(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode DetachChildAtForcibly(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscardForcibly(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode DetachChildAtAndDiscardForcibly(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool DetachChildForcibly(ISwiftNode child)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRangeForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRangeForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRangeForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRangeForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenWithRangeForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenWithRangeForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenWithRangeAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> DetachChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> DetachChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void DetachChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode DetachChildForcibly(int childIndex)
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

        ISwiftNode removedChild = Children[childIndex];
        Children.RemoveAt(childIndex);

        for (int i = childIndex; i < Children.Count; i++)
        {
            ISwiftNode child = Children[i];

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

    internal void DetachChildForcibly(int childIndex, Action<ISwiftNode> onChildDetachment)
    {
        ISwiftNode detachedChild = DetachChildForcibly(childIndex);
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