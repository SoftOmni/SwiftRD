using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    public virtual ISwiftNode RemoveChildAt(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode RemoveChildAt(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode RemoveChildAtAndDiscard(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool RemoveChild(ISwiftNode child)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRange(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRange(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRange(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRange(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscard(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildren(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRange(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRange(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscard(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public ISwiftNode RemoveChildAtForcibly(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode RemoveChildAtForcibly(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildAtAndDiscardForcibly(int index)
    {
        throw new NotImplementedException();
    }

    internal ISwiftNode RemoveChildAtAndDiscardForcibly(int index, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(int index, int count)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(int index, int count, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly(int startIndex, int endIndex, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(List<int> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes, Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool RemoveChildForcibly(ISwiftNode child)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRangeForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRangeForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscardForcibly(IEnumerable<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRangeForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRangeForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscardForcibly(IList<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenWithRangeForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenWithRangeForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenWithRangeAndDiscardForcibly(List<ISwiftNode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, Action<ISwiftNode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public List<ISwiftNode> RemoveChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal List<ISwiftNode> RemoveChildrenAtWithRangeForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }

    internal void RemoveChildrenAtWithRangeAndDiscardForcibly<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildDetachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        throw new NotImplementedException();
    }
}