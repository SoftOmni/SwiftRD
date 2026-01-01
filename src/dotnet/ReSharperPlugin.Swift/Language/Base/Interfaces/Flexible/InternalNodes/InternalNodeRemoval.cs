using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public INode RemoveChildAt(int index);
    
    public TNode RemoveChildAt<TNode>(int index) where TNode : INode;

    public INode RemoveChildAt(int index, Action<INode> onChildDetachment);
    
    public TNode RemoveChildAt<TNode>(int index, TNode child) where TNode : INode;

    public void RemoveChildAtAndDiscard(int index);

    public INode RemoveChildAtAndDiscard(int index, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(int index, int count);

    public List<INode> RemoveChildrenAt(int index, int count, Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(int index, int count);

    public void RemoveChildrenAtAndDiscard(int index, int count, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAtWithRange(int startIndex, int endIndex);

    public List<INode> RemoveChildrenAtWithRange(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex);

    public void RemoveChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IList<int> indexes);

    public List<INode> RemoveChildrenAt(IList<int> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildrenAt(IList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAtAndDiscard(IList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenAtWithRange(IList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenAtWithRangeAndDiscard(IList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(List<int> indexes);

    public List<INode> RemoveChildrenAt(List<int> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(List<int> indexes);

    public void RemoveChildrenAtAndDiscard(List<int> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildrenAt(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt<TList>(TList indexes) where TList : IList<int>;

    public List<INode> RemoveChildrenAt<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes) where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<int>;

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration) where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<int>;

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<int>;

    public List<INode> RemoveChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<int>;

    public void RemoveChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public List<INode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<int>;

    public List<INode> RemoveChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<int>;

    public void RemoveChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<int>;

    public bool RemoveChild(INode child);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(IList<INode> indexes);

    public List<INode> RemoveChildren(IList<INode> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IList<INode> indexes);

    public void RemoveChildrenAndDiscard(IList<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildren(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(List<INode> indexes);

    public List<INode> RemoveChildren(List<INode> indexes, Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(List<INode> indexes);

    public void RemoveChildrenAndDiscard(List<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration);

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration);

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> RemoveChildren(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void RemoveChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenWithRange(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> RemoveChildrenWithRange(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void RemoveChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void RemoveChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> RemoveChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public void RemoveChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;
}