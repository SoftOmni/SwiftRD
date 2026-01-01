using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public int InsertChild(int index, INode child);

    public int InsertChild(int index, INode child, Action<INode> actionOnAddition);

    public int InsertChild<TNode>(int index, INode child) where TNode : INode;

    public int InsertChild<TNode>(int index, INode child, Action<INode> actionOnAddition) where TNode : INode;

    public int InsertChildren(int index, IEnumerable<INode> children);
    
    public int InsertChildren(int index, IEnumerable<INode> children, Action<INode> onChildAddition);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration);
    
    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count);

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration);

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition);

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition);

    public int InsertChildren(int index, IList<INode> children);

    public int InsertChildren(int index, IList<INode> children, Action<INode> onChildAddition);

    public int InsertChildren(int index, IList<INode> children, int startIndexInCollection);

    public int InsertChildren(int index, IList<INode> children, int startIndexInCollection, Action<INode> onChildAddition);

    public int InsertChildren(int index, IList<INode> children, int startIndexInCollection, int count);

    public int InsertChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int InsertChildren(int index, IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition);

    public int InsertChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection,
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

    public int InsertChildren<TList, TListElements>(int index, TList children) where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode;

    public int InsertChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition) where TList : IList<TListElements> where TListElements : INode;
    
    public int PrependChild(INode child);
    
    public int PrependChild<TNode>(TNode child) where TNode : INode;

    internal int PrependChild(INode child, Action<INode> onChildAttachment);

    public int PrependChildren(IEnumerable<INode> children);

    internal int PrependChildren(IEnumerable<INode> children, Action<INode> onChildAttachment);

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection);

    internal int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count);

    public int PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public int PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    public int PrependChildren(IList<INode> children);

    internal int PrependChildren(IList<INode> children, Action<INode> onChildAttachment);

    public int PrependChildren(IList<INode> children, int startIndexInCollection);

    internal int PrependChildren(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int PrependChildren(IList<INode> children, int startIndexInCollection, int count);

    public int PrependChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int PrependChildren(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public int PrependChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public int PrependChildren(List<INode> children);

    internal int PrependChildren(List<INode> children, Action<INode> onChildAttachment);

    public int PrependChildren(List<INode> children, int startIndexInCollection);

    internal int PrependChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int PrependChildren(List<INode> children, int startIndexInCollection, int count);

    public int PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int PrependChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    public int PrependChildren<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildren<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment) where TList : IList<TListElements> where TListElements : INode;
    
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

    public int AppendChildren(IList<INode> children);

    internal int AppendChildren(IList<INode> children, Action<INode> onChildAttachment);

    public int AppendChildren(IList<INode> children, int startIndexInCollection);

    internal int AppendChildren(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(IList<INode> children, int startIndexInCollection, int count);

    public int AppendChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int AppendChildren(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    public int AppendChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children);

    internal int AppendChildren(List<INode> children, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children, int startIndexInCollection);

    internal int AppendChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren(List<INode> children, int startIndexInCollection, int count);

    public int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int AppendChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> onChildAttachment);

    public int AppendChildren<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildren<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment) where TList : IList<TListElements> where TListElements : INode;
}