using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    /*/// <summary>
    ///     <para>
    ///         Make the <see cref="INode"/> child at index <paramref name="index"/> a new <see cref="INode"/> node of its own tree.
    ///         This will remove the child as a child of this <see cref="INode"/>. That <see cref="INode"/> will no longer have a parent
    ///         (returned from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index of the child to remove in the <see cref="List{T}"/>-like (or <see cref="Array"/>-like) structure containing the children.
    ///  // TODO: review this wording
    /// </param>
    /// <returns>
    ///     The <see cref="INode"/> that has been detached and made a root of its own tree.
    /// </returns>
    public INode DetachChildAt(int index);

    public TNode DetachChildAt<TNode>(int index) where TNode : INode;

    public INode DetachChildAt(int index, Action<INode> onChildDetachment);

    public TNode DetachChildAt<TNode>(int index, Action<INode> onChildDetachment) where TNode : INode;

    public void DetachChildAtAndDiscard(int index);

    public void DetachChildAtAndDiscard<TNode>(int index) where TNode : INode;
    
    public void DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(int index, int count);

    public List<INode> DetachChildrenAt(int index, int count, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(int index, int count);

    public void DetachChildrenAtAndDiscard(int index, int count, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex);

    public List<INode> DetachChildrenAtWithRange(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex);

    public void DetachChildrenAtWithRangeAndDiscard(int startIndex, int endIndex, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildrenAt(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAtAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenAtWithRange(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenAtWithRangeAndDiscard(IEnumerable<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes, int startIndexInEnumeration);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildrenAt(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAtAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenAtWithRange(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenAtWithRangeAndDiscard(IReadOnlyList<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes);

    public List<INode> DetachChildrenAt(List<int> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes);

    public void DetachChildrenAtAndDiscard(List<int> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildrenAt(List<int> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAtAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenAtWithRange(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenAtWithRangeAndDiscard(List<int> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt<TList>(TList indexes) where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, Action<INode> onChildDetachment) where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes) where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, Action<INode> onChildDetachment)
        where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration) where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration) where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart) where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAt<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IReadOnlyList<int>;

    public void DetachChildrenAtAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IReadOnlyList<int>;

    public List<INode> DetachChildrenAtWithRange<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IReadOnlyList<int>;

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IReadOnlyList<int>;

    public void DetachChildrenAtWithRangeAndDiscard<TList>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IReadOnlyList<int>;

    public bool DetachChild(INode child);

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> indexes);

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, Action<INode> onChildDetachment);

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration);

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildren(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenWithRange(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenWithRangeAndDiscard(IEnumerable<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes);

    public List<INode> DetachChildren(IList<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes);

    public void DetachChildrenAndDiscard(IList<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildren(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenWithRange(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenWithRangeAndDiscard(IList<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes);

    public List<INode> DetachChildren(List<INode> indexes, Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes);

    public void DetachChildrenAndDiscard(List<INode> indexes, Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public List<INode> DetachChildren(List<INode> indexes, int startIndexInEnumeration, int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart);

    public void DetachChildrenAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public List<INode> DetachChildrenWithRange(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration);

    public void DetachChildrenWithRangeAndDiscard(List<INode> indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment);

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        Action<INode> onChildDetachment)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAt<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int countInEnumerationFromStart,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public List<INode> DetachChildrenAtWithRange<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : INode;

    public void DetachChildrenAtWithRangeAndDiscard<TList, TListElements>(TList indexes, int startIndexInEnumeration,
        int endIndexInEnumeration,
        Action<INode> onChildDetachment) where TList : IList<TListElements> where TListElements : INode;*/
}