using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public int PrependChild(INode child)
    {
        throw new NotImplementedException();
    }

    public int PrependChild<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChild(INode child, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildForcibly(INode child, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(IList<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly(List<INode> children, int startIndexInCollection, int count, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }
}