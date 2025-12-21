using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Base;

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

    internal int PrependChildForcibly(INode child);

    internal int PrependChildForcibly(INode child, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IEnumerable<INode> children);

    internal int PrependChildrenForcibly(IEnumerable<INode> children, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection);

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count);

    internal int PrependChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int PrependChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IList<INode> children);

    internal int PrependChildrenForcibly(IList<INode> children, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection);

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, int count);

    internal int PrependChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int PrependChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(List<INode> children);

    internal int PrependChildrenForcibly(List<INode> children, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection);

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, int count);

    internal int PrependChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int PrependChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int PrependChildrenForcibly<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment) where TList : IList<TListElements> where TListElements : INode;

    public int AppendChild(INode child);
    
    public int AppendChild<TNode>(TNode child) where TNode : INode;

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

    internal int AppendChildForcibly(INode child);

    internal int AppendChildForcibly(INode child, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IEnumerable<INode> children);

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection);

    internal int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count);

    internal int AppendChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int AppendChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IList<INode> children);

    internal int AppendChildrenForcibly(IList<INode> children, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection);

    internal int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection, int count);

    internal int AppendChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int AppendChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(List<INode> children);

    internal int AppendChildrenForcibly(List<INode> children, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(List<INode> children, int startIndexInCollection);

    internal int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, int count);

    internal int AppendChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection);

    internal int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment);

    internal int AppendChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment);

    internal int AppendChildrenForcibly<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    internal int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment) where TList : IList<TListElements> where TListElements : INode;
}