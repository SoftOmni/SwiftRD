using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Technology;

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

    protected virtual void CheckChildrenForSetting(List<ISwiftNode> newNodes)
    { }

    protected virtual List<ISwiftNode> CheckChildrenForSetting(IEnumerable<ISwiftNode> newNodes)
    {
        return newNodes.ToList();
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);

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

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, endInCollection);
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

    public int AttachChildren(int index, List<ISwiftNode> children)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return AttachChildrenUnchecked(index, children, 0, children.Count, AttachChild);
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

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChild);
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

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChild);
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

    public int AttachChildren(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildren);
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

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, List<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(index, children, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, AttachChildForcibly);
    }

    internal int AttachChildrenForcibly(int index, IEnumerable<ISwiftNode> children, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        return AttachChildren(index, children, startIndexInEnumeration, endIndexInEnumeration, AttachChildrenForcibly);
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

    public int PrependChild(ISwiftNode child)
    {
        return AttachChild(0, child);
    }

    public int PrependChildren(List<ISwiftNode> children)
    {
        return AttachChildren(0, children);
    }

    public int PrependChildren(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection);
    }

    public int PrependChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(0, children);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection);
    }

    public int PrependChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildForcibly(ISwiftNode child)
    {
        return AttachChildForcibly(0, child);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children)
    {
        return AttachChildrenForcibly(0, children);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children)
    {
        return AttachChildrenForcibly(0, children);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection);
    }

    internal int PrependChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(0, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChild(ISwiftNode child)
    {
        return AttachChild(Children.Count, child);
    }

    public int AppendChildren(List<ISwiftNode> children)
    {
        return AttachChildren(Children.Count, children);
    }

    public int AppendChildren(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection);
    }

    public int AppendChildren(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children)
    {
        return AttachChildren(Children.Count, children);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection);
    }

    public int AppendChildren(IEnumerable<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildren(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildForcibly(ISwiftNode child)
    {
        return AttachChildForcibly(Children.Count, child);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children)
    {
        return AttachChildrenForcibly(Children.Count, children);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly(List<ISwiftNode> children, int startIndexInCollection, int endIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children)
    {
        return AttachChildrenForcibly(Children.Count, children);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection);
    }

    internal int AppendChildrenForcibly(IEnumerable<ISwiftNode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        return AttachChildrenForcibly(Children.Count, children, startIndexInCollection, endIndexInCollection);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, extend);
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

    private void ReplaceChildrenAtUnderlying(int index, List<ISwiftNode> newNodes, int startInCollection,
        int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            AttachChild(placementIndex++, newNodes[startInCollection + i]);
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

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, extend);
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

    public virtual void ClearChildren()
    {
        while (Children.Count > 0)
        {
            DetachChild(Children.Count - 1);
        }
    }

    internal virtual void ClearChildrenForcibly()
    {
        while (Children.Count > 0)
        {
            DetachChildForcibly(Children.Count - 1);
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

    public virtual void DetachChild(int childIndex)
    {
        DetachChildForcibly(childIndex);
    }

    internal void DetachChildForcibly(int childIndex)
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

    public override void FindNodesAtInternal(TreeTextRange relativeRange, List<ITreeNode> result, bool includeContainingNodes)
    {
        throw new NotImplementedException();
    }
    
    protected static void CheckChildren(IEnumerable<ISwiftNode> child, params HashSet<Type> alwaysAllowedTypes)
    {
        
    }
    
    protected static void CheckChildren(List<ISwiftNode> child, params HashSet<Type> alwaysAllowedTypes)
    {
        
    }
    
    protected static void CheckChildren(IEnumerable<ISwiftNode> child, List<Type> expectedTypesTape)
    {
        
    }
    
    protected static void CheckChildren(List<ISwiftNode> child, List<Type> expectedTypesTape)
    {
        
    }
    
    protected static void CheckChildren(IEnumerable<ISwiftNode> child, List<Type> allowedTypesTape)
    {
        
    }
    
    protected static void CheckChildren(List<ISwiftNode> child, List<Type> allowedTypesTape)
    {
        
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