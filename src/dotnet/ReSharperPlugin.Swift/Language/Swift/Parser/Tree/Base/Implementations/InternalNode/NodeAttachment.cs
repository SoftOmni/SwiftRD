using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Technology;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    public virtual int AttachChild(int index, ISwiftNode child)
    {
        return AttachChildForcibly(index, child);
    }

    public int AttachChild(int index, ISwiftNode child, Action<ISwiftNode> actionOnAttachment)

    {
        int result = AttachChild(index, child);
        actionOnAttachment(child);

        return result;
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChild);
    }

    internal int AttachChildren(int index, IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, onChildAttachment, AttachChild);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        if (!enumerator.MoveNext())
        {
            enumerator.Dispose();
            return -1;
        }

        ISwiftNode firstNode = enumerator.Current!;
        int textInsertionIndex = attacher(index, firstNode);
        index++;

        while (enumerator.MoveNext())
        {
            ISwiftNode node = enumerator.Current!;
            attacher(index, node);
        }

        enumerator.Dispose();
        return textInsertionIndex;
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        if (!enumerator.MoveNext())
        {
            enumerator.Dispose();
            return -1;
        }

        ISwiftNode firstNode = enumerator.Current!;
        int textInsertionIndex = attacher(index, firstNode, onChildAttachment);
        index++;

        while (enumerator.MoveNext())
        {
            ISwiftNode node = enumerator.Current!;
            attacher(index, node, onChildAttachment);
        }

        enumerator.Dispose();
        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0]);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0], onChildAttachment);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0]);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0], onChildAttachment);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, Func<int, ISwiftNode, int> attacher)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0]);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (children.Count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[0], onChildAttachment);

        for (int i = 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChild);
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChild);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        if (!enumerator.MoveNext())
        {
            enumerator.Dispose();
            return -1;
        }

        ISwiftNode firstNode = enumerator.Current!;
        int textInsertionIndex = attacher(index, firstNode);
        index++;

        while (enumerator.MoveNext())
        {
            ISwiftNode node = enumerator.Current!;
            attacher(index, node);
        }

        enumerator.Dispose();
        return textInsertionIndex;
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        if (!enumerator.MoveNext())
        {
            enumerator.Dispose();
            return -1;
        }

        ISwiftNode firstNode = enumerator.Current!;
        int textInsertionIndex = attacher(index, firstNode);
        index++;

        while (enumerator.MoveNext())
        {
            ISwiftNode node = enumerator.Current!;
            attacher(index, node);
            onChildAttachment(node);
        }

        enumerator.Dispose();
        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Func<int, ISwiftNode, int> attacher)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, AttachChildren);
    }

    public int AttachChildrenWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildren);
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, onChildAttachment, AttachChildren);
    }

    public int AttachChildrenWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment, AttachChildren);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count,
        Func<int, List<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        int endIndexInEnumeration = startIndexInEnumeration + count;
        if (startIndexInEnumeration == endIndexInEnumeration)
        {
            return -1;
        }

        if (endIndexInEnumeration < startIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        List<ISwiftNode> childrenToAdd = [enumerator.Current!];

        while (enumerator.MoveNext() && enumerationIndex < endIndexInEnumeration)
        {
            ISwiftNode node = enumerator.Current!;
            childrenToAdd.Add(node);
            enumerationIndex++;
        }

        enumerator.Dispose();
        if (enumerationIndex < endIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        return attacher(index, childrenToAdd);
    }

    private int AttachChildrenWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Func<int, List<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        if (startIndexInEnumeration == endIndexInEnumeration)
        {
            return -1;
        }

        if (endIndexInEnumeration < startIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        List<ISwiftNode> childrenToAdd = [enumerator.Current!];

        while (enumerator.MoveNext() && enumerationIndex < endIndexInEnumeration)
        {
            ISwiftNode node = enumerator.Current!;
            childrenToAdd.Add(node);
            enumerationIndex++;
        }

        enumerator.Dispose();
        if (enumerationIndex < endIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        return attacher(index, childrenToAdd);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment, Func<int, List<ISwiftNode>, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInEnumeration = startIndexInEnumeration + count;
        if (endIndexInEnumeration == startIndexInEnumeration)
        {
            return -1;
        }

        if (endIndexInEnumeration < startIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        List<ISwiftNode> childrenToAdd = [enumerator.Current!];

        while (enumerator.MoveNext() && enumerationIndex < endIndexInEnumeration)
        {
            ISwiftNode node = enumerator.Current!;
            childrenToAdd.Add(node);
            enumerationIndex++;
        }

        enumerator.Dispose();
        if (enumerationIndex < endIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        return attacher(index, childrenToAdd, onChildAttachment);
    }

    private int AttachChildrenWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment, Func<int, List<ISwiftNode>, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration));
        }

        if (endIndexInEnumeration < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        if (endIndexInEnumeration == startIndexInEnumeration)
        {
            return -1;
        }

        if (endIndexInEnumeration < startIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        IEnumerator<ISwiftNode> enumerator = children.GetEnumerator();
        int enumerationIndex = 0;
        while (enumerator.MoveNext() && enumerationIndex < startIndexInEnumeration)
        {
            enumerator.MoveNext();
            enumerationIndex++;
        }

        if (enumerationIndex < startIndexInEnumeration)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startIndexInEnumeration)); //TODO: Write a better error message
        }

        List<ISwiftNode> childrenToAdd = [enumerator.Current!];

        while (enumerator.MoveNext() && enumerationIndex < endIndexInEnumeration)
        {
            ISwiftNode node = enumerator.Current!;
            childrenToAdd.Add(node);
            enumerationIndex++;
        }

        enumerator.Dispose();
        if (enumerationIndex < endIndexInEnumeration)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInEnumeration));
        }

        return attacher(index, childrenToAdd, onChildAttachment);
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, int count, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < 0 || endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment, Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, int count, Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment, Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count,
        Func<int, ISwiftNode, int> attacher) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAttachment, Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    private int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment, Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection >= children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    public int AttachChildren(int index, IList<ISwiftNode> children)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked(index, children, 0, children.Count, AttachChild);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked(index, children, 0, children.Count, AttachChild, onChildAttachment);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild, onChildAddition);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, int count)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildrenWithRange(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection, int count, Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild, onChildAddition);
    }

    public int AttachChildrenWithRange(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild, onChildAddition);
    }

    public int AttachChildren(int index, List<ISwiftNode> children)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked(index, children, 0, children.Count, AttachChild);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked(index, children, 0, children.Count, AttachChild, onChildAttachment);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild, onChildAddition);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, int count)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildrenWithRange(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild, onChildAddition);
    }

    public int AttachChildrenWithRange(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (0 < startIndexInCollection || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild, onChildAddition);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, 0, children.Count, AttachChild);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, 0, children.Count, AttachChild, onChildAttachment);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, children.Count, AttachChild);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, Action<ISwiftNode> onChildAddition)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, children.Count, AttachChild, onChildAddition);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }
    
    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection, int count,
        Action<ISwiftNode> onChildAddition) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endIndexInCollection = startIndexInCollection + count;
        if (endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, endIndexInCollection, AttachChild,
            onChildAddition);
    }

    public int AttachChildrenWithRange<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAddition) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < startIndexInCollection || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, endIndexInCollection, AttachChild,
            onChildAddition);
    }

    internal virtual int AttachChildForcibly(int index, ISwiftNode child)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        int textInsertionIndex;
        if (Children.Count == 0 || index == 0)
        {
            textInsertionIndex = 0;
        }
        else
        {
            textInsertionIndex = index - 1;
        }

        EditableBuffer.Insert(textInsertionIndex, child);
        if (child is SwiftInternalNode internalNode)
        {
            internalNode.EditableBuffer = new SubEditableBuffer(EditableBuffer, textInsertionIndex, internalNode.EditableBuffer.Length);
            internalNode.ParentIndex = index;
            internalNode.ParentTextIndex = textInsertionIndex;
        }
        else if (child is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer = new SubEditableBuffer(EditableBuffer, textInsertionIndex, leafNode.EditableBuffer.Length);
            leafNode.ParentIndex = index;
            leafNode.ParentTextIndex = textInsertionIndex;
        }

        Children.Insert(index, child);

        return textInsertionIndex;
    }

    internal virtual int AttachChildForcibly<TSwiftNode>(int index, TSwiftNode child) where TSwiftNode : ISwiftNode
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        int textInsertionIndex;
        if (Children.Count == 0 || index == 0)
        {
            textInsertionIndex = 0;
        }
        else
        {
            textInsertionIndex = index - 1;
        }

        EditableBuffer.Insert(textInsertionIndex, child);
        if (child is SwiftInternalNode internalNode)
        {
            internalNode.EditableBuffer = new SubEditableBuffer(EditableBuffer, textInsertionIndex, internalNode.EditableBuffer.Length);
            internalNode.ParentIndex = index;
            internalNode.ParentTextIndex = textInsertionIndex;
        }
        else if (child is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer = new SubEditableBuffer(EditableBuffer, textInsertionIndex, leafNode.EditableBuffer.Length);
            leafNode.ParentIndex = index;
            leafNode.ParentTextIndex = textInsertionIndex;
        }

        Children.Insert(index, child);

        return textInsertionIndex;
    }

    internal int AttachChildForcibly(int index, ISwiftNode child, Action<ISwiftNode> onChildAttachment)
    {
        int textInsertionIndex = AttachChildForcibly(index, child);
        onChildAttachment(child);

        return textInsertionIndex;
    }

    internal int AttachChildForcibly<TSwiftNode>(int index, TSwiftNode child, Action<TSwiftNode> onChildAttachment) where TSwiftNode : ISwiftNode
    {
        int textInsertionIndex = AttachChildForcibly(index, child);
        onChildAttachment(child);

        return textInsertionIndex;
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, onChildAttachment);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, AttachChildrenForcibly);
    }

    internal int AttachChildrenForciblyWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }
    
    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, onChildAttachment);
    }
    
    internal int AttachChildrenForciblyWithRange(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration, int count)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, AttachChildrenForcibly);
    }

    internal int AttachChildrenForciblyWithRange(int index, IList<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, onChildAttachment, AttachChildrenForcibly);
    }

    internal int AttachChildrenForciblyWithRange(int index, IList<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration, int count)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, AttachChildrenForcibly);
    }

    internal int AttachChildrenForciblyWithRange(int index, List<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, count, onChildAttachment, AttachChildrenForcibly);
    }

    internal int AttachChildrenForciblyWithRange(int index, List<ISwiftNode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenWithRange(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, onChildAttachment);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, count, AttachChildForcibly);
    }

    internal int AttachChildrenForciblyWithRange<TList, TListElements>(int index, TList children, int startIndexInEnumeration, int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration, int count,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, count, onChildAttachment,
            AttachChildForcibly);
    }

    internal int AttachChildrenForciblyWithRange<TList, TListElements>(int index, TList children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenWithRange<TList, TListElements>(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment,
            AttachChildForcibly);
    }

    private static int AttachChildrenUnchecked(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher)
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            index++;
        }

        return textInsertionIndex;
    }

    private static int AttachChildrenUnchecked(int index, IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment)
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            onChildAttachment(child);
            index++;
        }

        return textInsertionIndex;
    }

    private static int AttachChildrenUnchecked(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher)
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            index++;
        }

        return textInsertionIndex;
    }

    private static int AttachChildrenUnchecked(int index, List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment)
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            onChildAttachment(child);
            index++;
        }

        return textInsertionIndex;
    }

    private static int AttachChildrenUnchecked<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            index++;
        }

        return textInsertionIndex;
    }

    private static int AttachChildrenUnchecked<TList, TListElements>(int index, TList children, int startIndexInCollection, int endIndexInCollection,
        Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int count = endIndexInCollection - startIndexInCollection;
        if (count == 0)
        {
            return -1;
        }

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);
        index++;

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
            onChildAttachment(child);
            index++;
        }

        return textInsertionIndex;
    }
}