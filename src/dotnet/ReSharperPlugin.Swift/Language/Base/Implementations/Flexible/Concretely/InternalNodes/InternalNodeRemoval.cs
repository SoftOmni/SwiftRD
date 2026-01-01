using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public INode RemoveChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public TNode RemoveChildAt<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public INode RemoveChildAt(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public TNode RemoveChildAt<TNode>(int index, TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public INode RemoveChildAtAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(int index, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(int index, int count, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(int index, int count)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(int index, int count, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(int startIndex, int endIndex, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool RemoveChild(INode child)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }
}