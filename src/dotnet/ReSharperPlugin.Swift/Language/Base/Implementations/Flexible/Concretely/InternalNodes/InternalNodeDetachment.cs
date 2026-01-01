using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public INode DetachChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public INode DetachChildAt(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index, Action<INode> onChildDetachment)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(int index, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(int index, int count, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(int index, int count)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(int index, int count, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>
    {
        throw new NotImplementedException();
    }

    public bool DetachChild(INode child)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }
}