using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    internal int AppendChild(ISwiftNode child)
    {
        return AttachChild(Children.Count, child);
    }

    internal int AppendChild(ISwiftNode child, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChild(Children.Count, child, onChildAttachment);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(Children.Count, children);
    }

    internal int AppendChildren(IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, onChildAttachment);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count);
    }

    public int AppendChildrenWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    public int AppendChildrenWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(IList<ISwiftNode> children)
    {
        return AttachChildren(Children.Count, children);
    }

    internal int AppendChildren(IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, onChildAttachment);
    }

    public int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count);
    }

    public int AppendChildrenWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    public int AppendChildrenWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(List<ISwiftNode> children)
    {
        return AttachChildren(Children.Count, children);
    }

    internal int AppendChildren(List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, onChildAttachment);
    }

    public int AppendChildren(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count);
    }

    public int AppendChildrenWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int AppendChildrenWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int AppendChildren<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children);
    }

    internal int AppendChildren<TList, TListElements>(TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, onChildAttachment);
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection, count);
    }

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int AppendChildForcibly(ISwiftNode child)
    {
        return AttachChildForcibly(Children.Count, child);
    }

    internal int AppendChildForcibly(ISwiftNode child, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildForcibly(Children.Count, child, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children)
    {
        return AttachChildrenForcibly(Children.Count, children);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count);
    }

    internal int AppendChildrenForciblyWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int AppendChildrenForciblyWithRange(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children)
    {
        return AttachChildrenForcibly(Children.Count, children);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count);
    }

    internal int AppendChildrenForciblyWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int AppendChildrenForciblyWithRange(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children)
    {
        return AttachChildrenForcibly(Children.Count, children);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, onChildAttachment);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, int count)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count);
    }

    internal int AppendChildrenForciblyWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int AppendChildrenForciblyWithRange(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForciblyWithRange(Children.Count, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, count);
    }

    internal int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForciblyWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, count, onChildAttachment);
    }

    internal int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForciblyWithRange<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }
}