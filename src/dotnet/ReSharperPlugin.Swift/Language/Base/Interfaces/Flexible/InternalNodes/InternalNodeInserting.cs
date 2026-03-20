using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public int InsertChild(int index, INode child);

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition);

    public int InsertChild<TNode>(int index, TNode child) where TNode : INode;

    public int InsertChild<TNode>(int index, TNode child, Action<TNode> actionOnAddition) where TNode : INode;

    public int InsertChildren(int index, IEnumerable<INode> children);
    
    public int InsertChildren(int index, IEnumerable<INode> children, Action<INode> onChildAddition);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration);
    
    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count);

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition);

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition);

    public int InsertChildren(int index, IReadOnlyList<INode> children);

    public int InsertChildren(int index, IReadOnlyList<INode> children, Action<INode> onChildAddition);

    public int InsertChildren(int index, IReadOnlyList<INode> children, int startIndexInCollection);

    public int InsertChildren(int index, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> onChildAddition);

    public int InsertChildren(int index, IReadOnlyList<INode> children, int startIndexInCollection, int count);

    public int InsertChildrenWithRange(int index, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int InsertChildren(int index, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition);

    public int InsertChildrenWithRange(int index, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition);

    public int InsertChildren(int index, List<INode> children);

    public int InsertChildren(int index, List<INode> children, Action<INode> onChildAddition);

    public int InsertChildren(int index, List<INode> children, int startIndexInCollection);

    public int InsertChildren(int index, List<INode> children, int startIndexInCollection, Action<INode> onChildAddition);

    public int InsertChildren(int index, List<INode> children, int startIndexInCollection, int count);

    public int InsertChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int InsertChildren(int index, List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition);

    public int InsertChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition);

    public int InsertChildren<TList, TListElements>(int index, TList children) where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, Action<TListElements> onChildAddition)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<TListElements> onChildAddition)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count, Action<TListElements> onChildAddition)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int InsertChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TListElements> onChildAddition) where TList : IReadOnlyList<TListElements> where TListElements : INode;
    
    public void PrependChild(INode child);
    
    public void PrependChild<TNode>(TNode child) where TNode : INode;

    internal void PrependChild(INode child, Action<INode> onChildAttachment);

    public void PrependChildren(IEnumerable<INode> children);

    internal void PrependChildren(IEnumerable<INode> children, Action<INode> onChildAttachment);

    public void PrependChildren(IEnumerable<INode> children, int startIndexInCollection);

    internal void PrependChildren(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public void PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count);

    public void PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection);

    public void PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public void PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    public void PrependChildren(IReadOnlyList<INode> children);

    internal void PrependChildren(IReadOnlyList<INode> children, Action<INode> onChildAttachment);

    public void PrependChildren(IReadOnlyList<INode> children, int startIndexInCollection);

    internal void PrependChildren(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public void PrependChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count);

    public void PrependChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public void PrependChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public void PrependChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public void PrependChildren(List<INode> children);

    internal void PrependChildren(List<INode> children, Action<INode> onChildAttachment);

    public void PrependChildren(List<INode> children, int startIndexInCollection);

    internal void PrependChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public void PrependChildren(List<INode> children, int startIndexInCollection, int count);

    public void PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal void PrependChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal void PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    public void PrependChildren<TList, TListElements>(TList children) where TList : IReadOnlyList<TListElements> where TListElements : INode;

    internal void PrependChildren<TList, TListElements>(TList children, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public void PrependChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    internal void PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public void PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public void PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public void PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public void PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TListElements> onChildAttachment) where TList : IReadOnlyList<TListElements> where TListElements : INode;
    
    public int AppendChild(INode child);

    internal int AppendChild(INode child, Action<INode> onChildAttachment);

    public int AppendChildren(IEnumerable<INode> children);

    internal int AppendChildren(IEnumerable<INode> children, Action<INode> onChildAttachment);

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection);

    internal int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, int count);

    public int AppendChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public int AppendChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    public int AppendChildren(IReadOnlyList<INode> children);

    internal int AppendChildren(IReadOnlyList<INode> children, Action<INode> onChildAttachment);

    public int AppendChildren(IReadOnlyList<INode> children, int startIndexInCollection);

    internal int AppendChildren(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count);

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int AppendChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children);

    internal int AppendChildren(List<INode> children, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children, int startIndexInCollection);

    internal int AppendChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children, int startIndexInCollection, int count);

    public int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int AppendChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren<TList, TListElements>(TList children) where TList : IReadOnlyList<TListElements> where TListElements : INode;

    internal int AppendChildren<TList, TListElements>(TList children, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    internal int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<TListElements> onChildAttachment)
        where TList : IReadOnlyList<TListElements> where TListElements : INode;

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TListElements> onChildAttachment) where TList : IReadOnlyList<TListElements> where TListElements : INode;
}