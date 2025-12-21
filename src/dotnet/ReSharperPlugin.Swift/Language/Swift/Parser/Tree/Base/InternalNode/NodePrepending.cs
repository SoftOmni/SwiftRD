using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    public int PrependChild(ISwiftNode child)
    {
        return AttachChild(0, child);
    }

    internal int PrependChild(ISwiftNode child, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChild(0, child, onChildAttachment);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(0, children);
    }

    internal int PrependChildren(IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, onChildAttachment);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection);
    }

    internal int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(0, children, startIndexInCollection, count);
    }

    public int PrependChildrenWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, count, onChildAttachment);
    }

    public int PrependChildrenWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(IList<ISwiftNode> children)
    {
        return AttachChildren(0, children);
    }

    internal int PrependChildren(IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, onChildAttachment);
    }

    public int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection);
    }

    internal int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(0, children, startIndexInCollection, count);
    }

    public int PrependChildrenWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, count, onChildAttachment);
    }

    public int PrependChildrenWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(List<ISwiftNode> children)
    {
        return AttachChildren(0, children);
    }

    internal int PrependChildren(List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, onChildAttachment);
    }

    public int PrependChildren(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection);
    }

    internal int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(0, children, startIndexInCollection, count);
    }

    public int PrependChildrenWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int PrependChildrenWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int PrependChildren<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children);
    }

    internal int PrependChildren<TList, TListElements>(TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, onChildAttachment);
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection);
    }

    internal int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, count);
    }

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, count, onChildAttachment);
    }

    public int PrependChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int PrependChildForcibly(ISwiftNode child)
    {
        return AttachChildForcibly(0, child);
    }

    internal int PrependChildForcibly(ISwiftNode child, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildForcibly(0, child, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children)
    {
        return AttachChildrenForcibly(0, children);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count);
    }

    internal int PrependChildrenForciblyWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int PrependChildrenForciblyWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children)
    {
        return AttachChildrenForcibly(0, children);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count);
    }

    internal int PrependChildrenForciblyWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int PrependChildrenForciblyWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children)
    {
        return AttachChildrenForcibly(0, children);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, onChildAttachment);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count);
    }

    internal int PrependChildrenForciblyWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int PrependChildrenForciblyWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, count);
    }

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForciblyWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int PrependChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForciblyWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }
}