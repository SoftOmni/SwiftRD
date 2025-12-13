using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Technology;
using ReSharperPlugin.Swift.Technology.Graphs;
using ReSharperPlugin.Swift.Technology.Graphs.StateMachines;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftInternalNode : TreeElement, ISwiftNode
{
    protected readonly List<ISwiftNode> Children;

    public SwiftInternalNode? CoreParent { get; protected set; }

    protected SwiftInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
    {
        EditableBuffer = buffer;
        Children = children;
    }

    protected SwiftInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
    {
        EditableBuffer = buffer;
        Children = [..children];
    }

    protected SwiftInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex,
        IEditableBuffer buffer, List<ISwiftNode> nodes)
    {
        CoreParent = parent;
        Children = nodes;
        EditableBuffer = buffer;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    protected SwiftInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex,
        IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
    {
        CoreParent = parent;
        EditableBuffer = buffer;
        Children = [..nodes];
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    protected IEditableBuffer EditableBuffer { get; set; }

    public override NodeType NodeType => NodeTypes.NodeTypes.InternalNode;

    public ISwiftNode this[int index]
    {
        get => GetChildAt(index);
        set => SetChildAt(index, value);
    }

    public ISwiftNode GetChildAt(int index)
    {
        return Children[index];
    }

    public ISwiftNode? SetChildAt(int index, ISwiftNode newNode)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChild(newNode);
            return null;
        }

        ISwiftNode previousChild = Children[index];
        DetachChild(index);
        newNode.AttachToParent(this, index);

        return previousChild;
    }

    internal ISwiftNode? SetChildAt(int index, ISwiftNode newNode, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChild(newNode, onChildAttachment);
            return null;
        }

        ISwiftNode previousChild = Children[index];
        DetachChild(index);
        onChildDetachment(previousChild);
        newNode.AttachToParent(this, index);

        onChildAttachment(newNode);
        return previousChild;
    }

    protected virtual void CheckChildrenForSetting(List<ISwiftNode> newNodes)
    { }

    protected virtual void CheckChildrenForSetting<TList, TListElements>(TList newNodes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    { }

    protected virtual List<ISwiftNode> CheckChildrenForSetting(IEnumerable<ISwiftNode> newNodes)
    {
        return newNodes.ToList();
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, endInCollection);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, endInCollection);
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChild,
            onChildAttachment);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection,
        int endInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection,
        int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild,
            onChildAttachment);

        return oldChildren;
    }

    internal ISwiftNode? SetChildForciblyAt(int index, ISwiftNode newNode)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChildForcibly(newNode);
            return null;
        }

        ISwiftNode previousChild = Children[index];
        DetachChildForcibly(index);
        newNode.AttachToParent(this, index);

        return previousChild;
    }

    internal ISwiftNode? SetChildForciblyAt(int index, ISwiftNode newNode,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChildForcibly(newNode, onChildAttachment);
            return null;
        }

        ISwiftNode previousChild = Children[index];
        onChildDetachment(previousChild);

        DetachChildForcibly(index);
        newNode.AttachToParent(this, index);
        onChildAttachment(newNode);

        return previousChild;
    }

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);

        return oldChildren;
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
        return oldChildren;
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            enumerator.MoveNext();
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
        return oldChildren;
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, int startInCollection,
        int endInCollection)
    {
        if (startInCollection == endInCollection)
        {
            return [..Children];
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            enumerator.MoveNext();
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly);

        return oldChildren;
    }

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
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
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

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChild);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
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
        }

        enumerator.Dispose();
        return textInsertionIndex;
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment, Func<int, ISwiftNode, int> attacher)
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

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
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

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment,
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

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
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

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment,
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

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        Func<int, ISwiftNode, int> attacher)
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

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
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

        int textInsertionIndex = attacher(index, children[startIndexInCollection], onChildAttachment);

        for (int i = startIndexInCollection + 1; i < children.Count; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child, onChildAttachment);
        }

        return textInsertionIndex;
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildren);
    }

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment,
            AttachChildren);
    }

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Func<int, List<ISwiftNode>, int> attacher)
    {
        if (endIndexInEnumeration == startIndexInEnumeration)
        {
            return -1;
        }

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

    private int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment,
        Func<int, List<ISwiftNode>, Action<ISwiftNode>, int> attacher)
    {
        if (endIndexInEnumeration == startIndexInEnumeration)
        {
            return -1;
        }

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

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
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

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment,
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

        if (endIndexInCollection < 0 || endIndexInCollection >= children.Count)
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

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
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

        int textInsertionIndex = attacher(index, children[startIndexInCollection]);

        for (int i = startIndexInCollection + 1; i < endIndexInCollection; i++)
        {
            ISwiftNode child = children[i];
            attacher(index, child);
        }

        return textInsertionIndex;
    }

    private int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment,
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

        if (endIndexInCollection < 0 || endIndexInCollection >= children.Count)
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

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
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

        if (endIndexInCollection < 0 || endIndexInCollection >= children.Count)
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

    private int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment,
        Func<int, ISwiftNode, Action<ISwiftNode>, int> attacher)
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

        if (endIndexInCollection < 0 || endIndexInCollection >= children.Count)
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

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
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

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild,
            onChildAddition);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildren(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild,
            onChildAddition);
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

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
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

        return AttachChildrenUnchecked(index, children, startIndexInCollection, children.Count, AttachChild,
            onChildAddition);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild);
    }

    public int AttachChildren(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAddition)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startIndexInCollection < 0 || startIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startIndexInCollection));
        }

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked(index, children, startIndexInCollection, endIndexInCollection, AttachChild,
            onChildAddition);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
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

        return AttachChildrenUnchecked<TList, TListElements>(index, children, 0, children.Count, AttachChild,
            onChildAttachment);
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

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, children.Count,
            AttachChild);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAddition)
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

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection, children.Count,
            AttachChild,
            onChildAddition);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection)
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

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection,
            endIndexInCollection, AttachChild);
    }

    public int AttachChildren<TList, TListElements>(int index, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAddition)
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

        if (endIndexInCollection < 0 || endIndexInCollection > children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        if (startIndexInCollection > endIndexInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endIndexInCollection));
        }

        return AttachChildrenUnchecked<TList, TListElements>(index, children, startIndexInCollection,
            endIndexInCollection, AttachChild, onChildAddition);
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
            internalNode.EditableBuffer =
                new SubEditableBuffer(EditableBuffer, textInsertionIndex, internalNode.EditableBuffer.Length);
            internalNode.ParentIndex = index;
            internalNode.ParentTextIndex = textInsertionIndex;
        }
        else if (child is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer =
                new SubEditableBuffer(EditableBuffer, textInsertionIndex, leafNode.EditableBuffer.Length);
            leafNode.ParentIndex = index;
            leafNode.ParentTextIndex = textInsertionIndex;
        }

        Children.Insert(index, child);

        return textInsertionIndex;
    }

    internal virtual int AttachChildForcibly<TSwiftNode>(int index, TSwiftNode child)
        where TSwiftNode : ISwiftNode
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
            internalNode.EditableBuffer =
                new SubEditableBuffer(EditableBuffer, textInsertionIndex, internalNode.EditableBuffer.Length);
            internalNode.ParentIndex = index;
            internalNode.ParentTextIndex = textInsertionIndex;
        }
        else if (child is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer =
                new SubEditableBuffer(EditableBuffer, textInsertionIndex, leafNode.EditableBuffer.Length);
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

    internal int AttachChildForcibly<TSwiftNode>(int index, TSwiftNode child, Action<TSwiftNode> onChildAttachment)
        where TSwiftNode : ISwiftNode
    {
        int textInsertionIndex = AttachChildForcibly(index, child);
        onChildAttachment(child);

        return textInsertionIndex;
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children,
        Action<ISwiftNode> onChildAttachment)
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

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
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

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, IList<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment,
            AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, onChildAttachment, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, onChildAttachment,
            AttachChildrenForcibly);
    }
    
    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children,
        Action<ISwiftNode> onChildAttachment)
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
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, onChildAttachment,
            AttachChildForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, endIndexInEnumeration,
            AttachChildForcibly);
    }

    internal int AttachChildrenForcibly<TList, TListElements>(int index, TList children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(index, children, startIndexInEnumeration, endIndexInEnumeration,
            onChildAttachment, AttachChildForcibly);
    }

    private static int AttachChildrenUnchecked(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
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

    private static int AttachChildrenUnchecked(int index, IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment)
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

    private static int AttachChildrenUnchecked(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
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

    private static int AttachChildrenUnchecked(int index, List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment)
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

    private static int AttachChildrenUnchecked<TList, TListElements>(int index, TList children,
        int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher)
        where TList : IList<TListElements> where TListElements : ISwiftNode
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

    private static int AttachChildrenUnchecked<TList, TListElements>(int index, TList children,
        int startIndexInCollection,
        int endIndexInCollection, Func<int, ISwiftNode, int> attacher, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
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

    internal int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
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

    internal int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
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

    internal int PrependChildren(List<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    public int PrependChildren<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
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

    internal int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
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

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
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

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
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

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
    }

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

    internal int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
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

    internal int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren(IList<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
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

    internal int AppendChildren(List<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    public int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
    }

    public int AppendChildren<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
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

    internal int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection,
            onChildAttachment);
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection,
            endIndexInCollection);
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildren<TList, TListElements>(Children.Count, children, startIndexInCollection,
            endIndexInCollection,
            onChildAttachment);
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

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
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

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(IList<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
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

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, onChildAttachment);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        return AttachChildrenForcibly<TList, TListElements>(0, children, startIndexInCollection, endIndexInCollection,
            onChildAttachment);
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChild(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChild(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlying(index, nodesToAdd, 0, nodesToAdd.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlying(index, nodesToAdd, 0, nodesToAdd.Count, onChildDetachment,
            onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes,
        Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, 0, newNodes.Count, onChildDetachment,
            onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection,
            startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection,
            startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes,
        int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    private void ReplaceChildrenAtUnderlying(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlying<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChildForcibly(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildForciblyAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChildForcibly(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildForciblyAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, nodesToAdd, 0, nodesToAdd.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, nodesToAdd, 0, nodesToAdd.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment,
            extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment,
            extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes,
        Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, 0, newNodes.Count, onChildDetachment,
            onChildAttachment,
            extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection,
            startInCollection + newNodes.Count,
            extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection,
            startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, endInCollection,
            extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, endInCollection,
            onChildDetachment, onChildAttachment, extend);
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            AttachChildForcibly(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, IList<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            AttachChildForcibly(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly<TList, TListElement>(int index, TList newNodes,
        int startInCollection,
        int endInCollection, bool extend = false)
        where TList : IList<TListElement> where TListElement : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(int index, TList newNodes,
        int startInCollection,
        int endInCollection, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    public virtual void ClearChildren()
    {
        while (Children.Count > 0)
        {
            DetachChild(Children.Count - 1);
        }
    }

    internal virtual void ClearChildren(Action<ISwiftNode> onChildDetachment)
    {
        while (Children.Count > 0)
        {
            DetachChild(Children.Count - 1, onChildDetachment);
        }
    }

    internal virtual void ClearChildrenForcibly()
    {
        while (Children.Count > 0)
        {
            DetachChildForcibly(Children.Count - 1);
        }
    }

    internal virtual void ClearChildrenForcibly(Action<ISwiftNode> onChildDetachment)
    {
        while (Children.Count > 0)
        {
            DetachChildForcibly(Children.Count - 1, onChildDetachment);
        }
    }

    public SwiftInternalNode? GetParent()
    {
        return CoreParent;
    }

    public bool HasParent()
    {
        return CoreParent is not null;
    }

    public int ParentIndex { get; internal set; }

    public int ParentTextIndex { get; internal set; }

    public IBuffer GetBuffer()
    {
        return EditableBuffer;
    }

    public int NumberOfChildren()
    {
        return Children.Count;
    }

    // In future, optimize more cloning algorithms for performance
    protected abstract SwiftInternalNode DuplicateWithoutChildren();

    protected abstract SwiftInternalNode Duplicate();

    public ISwiftNode CloneAsDetachedShallow()
    {
        return Duplicate();
    }

    public ISwiftNode CloneAsDetachedDeep()
    {
        SwiftInternalNode newNode = DuplicateWithoutChildren();
        for (int index = 0; index < Children.Count; index++)
        {
            ISwiftNode child = Children[index];
            ISwiftNode cloned = child.CloneAsDetachedDeep();

            newNode.AttachChildForcibly(index, cloned);
        }

        return newNode;
    }

    internal ISwiftNode CloneAsDetachedDeep(int depth, ISwiftNode.DepthCloningMode cloningMode)
    {
        if (depth < 0)
        {
            return CloneAsDetachedDeep();
        }

        return CloneAsDetachedDeepRecursive(depth, cloningMode);
    }

    private ISwiftNode CloneAsDetachedDeepRecursive(int depth, ISwiftNode.DepthCloningMode cloningMode)
    {
        if (depth == 0)
        {
            if (cloningMode is ISwiftNode.DepthCloningMode.HardStop)
            {
                return DuplicateWithoutChildren();
            }

            return Duplicate();
        }

        SwiftInternalNode newNode = DuplicateWithoutChildren();
        for (int index = 0; index < Children.Count; index++)
        {
            ISwiftNode child = Children[index];
            if (child is SwiftInternalNode internalChild)
            {
                ISwiftNode cloned = internalChild.CloneAsDetachedDeep(depth - 1, cloningMode);
                newNode.AttachChildForcibly(index, cloned);
            }
            else if (child is SwiftLeafNode leafChild)
            {
                ISwiftNode cloned = leafChild.CloneAsDetachedShallow();
                newNode.AttachChildForcibly(index, cloned);
            }
        }

        return newNode;
    }

    public ISwiftNode CloneAsAttachedToShallow(int index, SwiftInternalNode newParent)
    {
        ISwiftNode cloned = CloneAsDetachedShallow();
        cloned.AttachToParent(newParent, index);

        return cloned;
    }

    public ISwiftNode CloneAsAttachedToDeep(int index, SwiftInternalNode newParent)
    {
        ISwiftNode cloned = CloneAsDetachedDeep();
        cloned.AttachToParent(newParent, index);

        return cloned;
    }

    public ISwiftNode CloneAsAttachedToDeep(int index, SwiftInternalNode newParent, int depth,
        ISwiftNode.DepthCloningMode cloningMode)
    {
        ISwiftNode cloned = CloneAsDetachedDeep(depth, cloningMode);
        cloned.AttachToParent(newParent, index);

        return cloned;
    }

    public virtual void AttachToParent(SwiftInternalNode newParent, int parentIndex)
    {
        CoreParent?.DetachChild(ParentIndex);
        ParentTextIndex = newParent.AttachChild(parentIndex, this);
        CoreParent = newParent;
        ParentIndex = parentIndex;
    }

    internal virtual void AttachToParentForcibly(SwiftInternalNode newParent, int parentIndex)
    {
        CoreParent?.DetachChild(ParentIndex);
        ParentTextIndex = newParent.AttachChildForcibly(parentIndex, this);
        CoreParent = newParent;
        ParentIndex = parentIndex;
    }

    public virtual ISwiftNode DetachChild(int childIndex)
    {
        return DetachChildForcibly(childIndex);
    }
    
    internal void DetachChild(int childIndex, Action<ISwiftNode> onChildDetachment)
    {
        ISwiftNode detachedChild = DetachChild(childIndex);
        onChildDetachment(detachedChild);
    }

    internal ISwiftNode DetachChildForcibly(int childIndex)
    {
        if (childIndex < 0 || childIndex > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(childIndex));
        }

        int start = Children[childIndex].ParentTextIndex;
        int end = childIndex + 1 == Children.Count
            ? EditableBuffer.Length
            : Children[childIndex + 1].ParentTextIndex;

        IEditableBuffer newChildBuffer = EditableBufferExtensions.CloneBuffer(EditableBuffer, start, end);
        if (Children[childIndex] is SwiftInternalNode internalNode)
        {
            internalNode.EditableBuffer = newChildBuffer;
            internalNode.CoreParent = null;
        }
        else if (Children[childIndex] is SwiftLeafNode leafNode)
        {
            leafNode.EditableBuffer = newChildBuffer;
            leafNode.CoreParent = null;
        }

        int length = end - start;
        newChildBuffer.Remove(start, length);

        ISwiftNode removedChild = Children[childIndex];
        Children.RemoveAt(childIndex);

        for (int i = childIndex; i < Children.Count; i++)
        {
            ISwiftNode child = Children[i];

            switch (child)
            {
                case SwiftInternalNode internalChild:
                    internalChild.ParentTextIndex -= length;
                    break;
                case SwiftLeafNode leafChild:
                    leafChild.ParentTextIndex -= length;
                    break;
            }
        }

        return removedChild;
    }
    
    internal void DetachChildForcibly(int childIndex, Action<ISwiftNode> onChildDetachment)
    {
        ISwiftNode detachedChild = DetachChildForcibly(childIndex);
        onChildDetachment(detachedChild);
    }

    public void DetachFromParent()
    {
        CoreParent?.DetachChild(ParentIndex);
    }

    internal void DetachFromParentForcibly()
    {
        CoreParent?.DetachChildForcibly(ParentIndex);
    }

    public override string GetText()
    {
        return EditableBuffer.GetText();
    }

    public override int GetTextLength()
    {
        return EditableBuffer.Length;
    }

    public override StringBuilder GetText(StringBuilder to)
    {
        return StringBuilderExtensions.Append(EditableBuffer, to);
    }

    public override IBuffer GetTextAsBuffer()
    {
        return EditableBuffer;
    }

    public override ITreeNode? FirstChild => Children.Count > 0 ? Children[0] : null;

    public override ITreeNode? LastChild => Children.Count > 0 ? Children[Children.Count - 1] : null;

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public override ITreeNode FindNodeAt(TreeTextRange treeRange)
    {
        throw new NotImplementedException();
    }

    public override void FindNodesAtInternal(TreeTextRange relativeRange, List<ITreeNode> result,
        bool includeContainingNodes)
    {
        throw new NotImplementedException();
    }

    protected void CheckChildren(Type expectedChildType, HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        CheckChildren(GetType(), Children, expectedChildType, alwaysAllowedTypes, allowMultiples);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> childrenToCheck,
        Type expectedChildType, HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (ISwiftNode directChild in childrenToCheck)
        {
            Type directChildType = directChild.GetType();
            if (directChildType == expectedChildType)
            {
                if (sawChild && !allowMultiples)
                {
                    throw new SyntaxError(
                        $"The child of type {expectedChildType} was only allowed once but showed up more than once as a child of {currentType} (not semantically)");
                }

                sawChild = true;
            }
            else if (!alwaysAllowedTypes.Contains(directChildType))
            {
                throw new SyntaxError(
                    $"The child of type {directChildType} is forbidden as a child of {currentType} syntactically (not semantically)");
            }
        }
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> childrenToCheck, Type expectedChildType,
        HashSet<Type> alwaysAllowedTypes, bool allowMultiples = false)
    {
        bool sawChild = false;
        foreach (ISwiftNode directChild in childrenToCheck)
        {
            Type directChildType = directChild.GetType();
            if (directChildType == expectedChildType)
            {
                if (sawChild && !allowMultiples)
                {
                    throw new SyntaxError(
                        $"The child of type {expectedChildType} was only allowed once but showed up more than once as a child of {currentType} (not semantically)");
                }

                sawChild = true;
            }
            else if (!alwaysAllowedTypes.Contains(directChildType))
            {
                throw new SyntaxError(
                    $"The child of type {directChildType} is forbidden as a child of {currentType} syntactically (not semantically)");
            }
        }
    }

    protected void CheckChildren(IEnumerable<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes,
        bool allowIncomplete = false)
    {
        CheckChildren(GetType(), Children, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }


    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> childrenToCheck,
        IEnumerable<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        IEnumerator<Type> expectedTypesEnumerator = expectedChildTypes.GetEnumerator();
        IEnumerator<ISwiftNode> childEnumerator = childrenToCheck.GetEnumerator();
        while (expectedTypesEnumerator.MoveNext())
        {
            Type childType = expectedTypesEnumerator.Current!;
            bool containsMoreChildren = childEnumerator.MoveNext();
            while (containsMoreChildren && childType != childEnumerator.Current!.GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    expectedTypesEnumerator.Dispose();
                    childEnumerator.Dispose();
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                containsMoreChildren = childEnumerator.MoveNext();
            }

            if (containsMoreChildren)
            {
                continue;
            }

            childEnumerator.Dispose();
            expectedTypesEnumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        expectedTypesEnumerator.Dispose();
        while (childEnumerator.MoveNext())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        childEnumerator.Dispose();
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> childrenToCheck,
        IEnumerable<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        IEnumerator<Type> enumerator = expectedChildTypes.GetEnumerator();
        int childIndex = 0;
        while (enumerator.MoveNext())
        {
            Type childType = enumerator.Current!;
            while (childIndex < childrenToCheck.Count && childType != childrenToCheck[childIndex].GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    enumerator.Dispose();
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                childIndex++;
            }

            if (childIndex != childrenToCheck.Count)
            {
                childIndex++;
                continue;
            }

            enumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        enumerator.Dispose();
        while (childIndex < childrenToCheck.Count)
        {
            if (!alwaysAllowedTypes.Contains(childrenToCheck[childIndex].GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {childrenToCheck[childIndex].GetType()} as a child of {currentType}");
            }
        }
    }

    protected void CheckChildren(List<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes,
        bool allowIncomplete = false)
    {
        CheckChildren(GetType(), Children, expectedChildTypes, alwaysAllowedTypes, allowIncomplete);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> newChildren,
        List<Type> expectedChildTypes, HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        int childTypesIndex = 0;
        IEnumerator<ISwiftNode> childEnumerator = newChildren.GetEnumerator();
        while (childTypesIndex < expectedChildTypes.Count)
        {
            Type expectedChildType = expectedChildTypes[childTypesIndex];
            bool containsMoreChildren = childEnumerator.MoveNext();
            while (containsMoreChildren && !expectedChildType.IsInstanceOfType(childEnumerator.Current!))
            {
                if (!alwaysAllowedTypes.Contains(expectedChildType))
                {
                    childEnumerator.Dispose();
                    throw new SyntaxError(
                        $"Error: came across a forbidden {expectedChildType} as a child of {currentType}");
                }

                containsMoreChildren = childEnumerator.MoveNext();
            }

            if (containsMoreChildren)
            {
                childTypesIndex++;
                continue;
            }

            childEnumerator.Dispose();
            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError(
                $"Error: did not come across the expected {expectedChildType} as a child of {currentType}");
        }

        while (childEnumerator.MoveNext())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }
    }

    protected void CheckChildren(ReadOnlyStateMachine<Type> expectedTypesStateMachine, HashSet<Type> alwaysAllowedTypes)
    {
        CheckChildren(GetType(), Children, expectedTypesStateMachine, alwaysAllowedTypes);
    }

    protected static void CheckChildren(Type currentType, IEnumerable<ISwiftNode> newChildren,
        ReadOnlyStateMachine<Type> expectedTypesStateMachine, HashSet<Type> alwaysAllowedTypes)
    {
        ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode current = expectedTypesStateMachine.StartNode;
        IEnumerator<ISwiftNode> childEnumerator = newChildren.GetEnumerator();
        bool containsMoreChildren = childEnumerator.MoveNext();
        while (containsMoreChildren && current.Value != childEnumerator.Current!.GetType())
        {
            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        if (!containsMoreChildren)
        {
            if (!current.IsAcceptState)
            {
                SyntaxError syntaxError =
                    new(
                        $"Error: did not come across the expected {childEnumerator.Current!.GetType()} as a child of {currentType}");
                childEnumerator.Dispose();
                throw syntaxError;
            }

            childEnumerator.Dispose();
            return;
        }

        while (childEnumerator.MoveNext())
        {
            if (current.TryGetEdgeTo(childEnumerator.Current!.GetType(), out IReadOnlyNode<Type>? newCurrent))
            {
                current = newCurrent as ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode ??
                          throw new ArgumentNullException(nameof(current));
                continue;
            }

            if (!alwaysAllowedTypes.Contains(childEnumerator.Current!.GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {childEnumerator.Current!.GetType()} as a child of {currentType}");
            }
        }

        if (current.IsAcceptState)
        {
            return;
        }

        string joinedChildren = string.Join(", ", current.GetOutgoingEdges().Select((node => node.Value)));
        throw new SyntaxError(
            $"Expected one of the following nodes: {joinedChildren} after {current.Value} as a child of {currentType}");
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> newChildren, List<Type> expectedChildTypes,
        HashSet<Type> alwaysAllowedTypes, bool allowIncomplete = false)
    {
        int childTypesIndex = 0;
        int childIndex = 0;
        while (childTypesIndex < expectedChildTypes.Count)
        {
            Type childType = expectedChildTypes[childTypesIndex];
            while (childIndex < newChildren.Count && childType != newChildren[childIndex].GetType())
            {
                if (!alwaysAllowedTypes.Contains(childType))
                {
                    throw new SyntaxError($"Error: came across a forbidden {childType} as a child of {currentType}");
                }

                childIndex++;
            }

            if (childIndex != newChildren.Count)
            {
                childIndex++;
                childTypesIndex++;
                continue;
            }

            if (!allowIncomplete)
            {
                return;
            }

            throw new SyntaxError($"Error: did not come across the expected {childType} as a child of {currentType}");
        }

        while (childIndex < newChildren.Count)
        {
            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }
        }
    }

    protected static void CheckChildren(Type currentType, List<ISwiftNode> newChildren,
        ReadOnlyStateMachine<Type> expectedTypesStateMachine, HashSet<Type> alwaysAllowedTypes)
    {
        ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode current = expectedTypesStateMachine.StartNode;
        int childIndex = 0;
        while (childIndex < newChildren.Count && current.Value != newChildren[childIndex].GetType())
        {
            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }

            childIndex++;
        }

        if (childIndex == newChildren.Count)
        {
            if (!current.IsAcceptState)
            {
                throw new SyntaxError(
                    $"Error: did not come across the expected {newChildren[childIndex].GetType()} as a child of {currentType}");
            }

            return;
        }

        while (childIndex < newChildren.Count)
        {
            if (current.TryGetEdgeTo(newChildren[childIndex].GetType(), out IReadOnlyNode<Type>? newCurrent))
            {
                current = newCurrent as ReadOnlyStateMachine<Type>.ReadOnlyStateMachineNode ??
                          throw new ArgumentNullException(nameof(current));
                childIndex++;
                continue;
            }

            if (!alwaysAllowedTypes.Contains(newChildren[childIndex].GetType()))
            {
                throw new SyntaxError(
                    $"Error: came across a forbidden {newChildren[childIndex].GetType()} as a child of {currentType}");
            }
        }

        if (current.IsAcceptState)
        {
            return;
        }

        string joinedChildren = string.Join(", ", current.GetOutgoingEdges().Select((node => node.Value)));
        throw new SyntaxError(
            $"Expected one of the following nodes: {joinedChildren} after {current.Value} as a child of {currentType}");
    }

    public int TextIndexOfInsertingAt(int index)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            return 0;
        }

        ISwiftNode precedingChild = Children[index - 1];
        return precedingChild.ParentTextIndex + precedingChild.GetTextLength();
    }
}

internal static class EditableBufferExtensions
{
    public static IEditableBuffer CloneBuffer(IEditableBuffer editableBuffer)
    {
        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = 0; i < editableBuffer.Length; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    public static IEditableBuffer CloneBuffer(IEditableBuffer editableBuffer, int start, int end)
    {
        if (start < 0 || start > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        if (end < 0 || end > editableBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(end));
        }

        EditableBuffer newBuffer = new(editableBuffer.Length);
        for (int i = start; i < end; i++)
        {
            newBuffer.Insert(i, editableBuffer[i].ToString());
        }

        return newBuffer;
    }

    internal static IEditableBuffer CombineBuffers(int capacity, params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new(capacity);

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }

        return finalBuffer;
    }

    internal static IEditableBuffer CombineBuffers(params IBuffer[] buffers)
    {
        EditableBuffer finalBuffer = new();

        for (int buffersIndex = 0; buffersIndex < finalBuffer.Length; buffersIndex++)
        {
            IBuffer buffer = buffers[buffersIndex];

            for (int bufferIndex = 0; bufferIndex < buffer.Length; bufferIndex++)
            {
                finalBuffer.Insert(finalBuffer.Length, buffer[bufferIndex].ToString());
            }
        }

        return finalBuffer;
    }
}