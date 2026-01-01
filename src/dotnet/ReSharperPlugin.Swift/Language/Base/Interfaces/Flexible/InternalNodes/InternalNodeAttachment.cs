using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public int AttachChild(int index, INode child);

    public int AttachChild(int index, INode child, Action<INode> actionOnAttachment);

    public int AttachChild<TNode>(int index, INode child) where TNode : INode;

    public int AttachChild<TNode>(int index, INode child, Action<INode> actionOnAttachment) where TNode : INode;

    public int AttachChildren(int index, IEnumerable<INode> children);
    
    public int AttachChildren(int index, IEnumerable<INode> children, Action<INode> onChildAttachment);

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration);
    
    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition);

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count);

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration);

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAttachment);

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAttachment);

    public int AttachChildren(int index, IList<INode> children);

    public int AttachChildren(int index, IList<INode> children, Action<INode> onChildAttachment);

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection);

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, Action<INode> onChildAddition);

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, int count);

    public int AttachChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition);

    public int AttachChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition);

    public int AttachChildren(int index, List<INode> children);

    public int AttachChildren(int index, List<INode> children, Action<INode> onChildAttachment);

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection);

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, Action<INode> onChildAddition);

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, int count);

    public int AttachChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection);

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition);

    public int AttachChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition);

    public int AttachChildren<TList, TListElements>(int index, TList children) where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildren<TList, TListElements>(int index, TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode;

    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition) where TList : IList<TListElements> where TListElements : INode;
}