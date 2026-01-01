using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public int AttachChild(int index, INode child)
    {
        throw new NotImplementedException();
    }

    public int AttachChild(int index, INode child, Action<INode> actionOnAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, INode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChild<TNode>(int index, INode child, Action<INode> actionOnAttachment)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count,
        Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<INode> onChildAddition)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }
}