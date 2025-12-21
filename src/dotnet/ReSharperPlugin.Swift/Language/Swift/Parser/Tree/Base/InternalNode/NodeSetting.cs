using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
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

    public void SetChildAtAndDiscard(int index, ISwiftNode newNode)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChild(newNode);
            return;
        }

        DetachChild(index);
        newNode.AttachToParent(this, index);
    }

    internal ISwiftNode? SetChildAt(int index, ISwiftNode newNode, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
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

    internal void SetChildAtAndDiscard(int index, ISwiftNode newNode, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChild(newNode, onChildAttachment);
            return;
        }

        ISwiftNode previousChild = Children[index];
        DetachChild(index);
        onChildDetachment(previousChild);
        newNode.AttachToParent(this, index);

        onChildAttachment(newNode);
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

    public void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, onChildDetachment, onChildAttachment);
    }

    internal void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren, onChildDetachment, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection);
    }

    public void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren, startInCollection);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, onChildDetachment, onChildAttachment);
    }

    internal void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren, startInCollection, onChildDetachment, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, count);
    }

    public void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren, startInCollection, count);
    }

    internal List<ISwiftNode> SetChildren(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildren(newChildren, startInCollection, count, onChildDetachment, onChildAttachment);
    }

    internal void SetChildrenAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildren(newChildren, startInCollection, count, onChildDetachment, onChildAttachment);
    }

    public List<ISwiftNode> SetChildrenWithRange(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endIndexInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildrenWithRange(newChildren, startInCollection, endIndexInCollection);
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endIndexInCollection)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildrenWithRangeAndDiscard(newChildren, startInCollection, endIndexInCollection);
    }

    internal List<ISwiftNode> SetChildrenWithRange(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        return SetChildrenWithRange(newChildren, startInCollection, endIndexInCollection, onChildDetachment, onChildAttachment);
    }

    internal void SetChildrenWithRangeAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endIndexInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> newChildren = CheckChildrenForSetting(newNodes);
        SetChildrenWithRangeAndDiscard(newChildren, startInCollection, endIndexInCollection, onChildDetachment, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public void SetChildrenAndDiscard(IList<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);
    }

    internal List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenAndDiscard(IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);
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

    public void SetChildrenAndDiscard(IList<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild);
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
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

    public void SetChildrenAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public void SetChildrenAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildren(IList<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public void SetChildrenAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildrenWithRange(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public void SetChildrenWithRangeAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildrenWithRange(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public void SetChildrenWithRangeAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public void SetChildrenAndDiscard(List<ISwiftNode> newNodes)
    {
        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild);
    }

    internal List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenAndDiscard(List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);
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

    public void SetChildrenAndDiscard(List<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild);
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
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

    public void SetChildrenAndDiscard(List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }
    
    public void SetChildrenAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildren(List<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public void SetChildrenAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildrenWithRange(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public void SetChildrenWithRangeAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildrenWithRange(List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }

    public void SetChildrenWithRangeAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild);

        return oldChildren;
    }

    public void SetChildrenAndDiscard<TList, TListElements>(TList newNodes) 
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild);
    }

    internal List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenAndDiscard<TList, TListElements>(TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChild, onChildAttachment);
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

    public void SetChildrenAndDiscard<TList, TListElements>(TList newNodes, int startInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChild);
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);

        return oldChildren;
    }
    
    public void SetChildrenAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }

    public void SetChildrenAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildren<TList, TListElements>(TList newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }
    
    public void SetChildrenAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int count, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
    }

    public List<ISwiftNode> SetChildrenWithRange<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection)
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

        if (endInCollection > startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild);

        return oldChildren;
    }
    
    public void SetChildrenWithRangeAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection)
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

        if (endInCollection > startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild);
    }

    public List<ISwiftNode> SetChildrenWithRange<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection > startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);

        return oldChildren;
    }
    
    public void SetChildrenWithRangeAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection,
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

        if (endInCollection > startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        CheckChildrenForSetting<TList, TListElements>(newNodes);
        ClearChildren(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChild, onChildAttachment);
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

    internal void SetChildForciblyAtAndDiscard(int index, ISwiftNode newNode)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChildForcibly(newNode);
            return;
        }
        
        DetachChildForcibly(index);
        newNode.AttachToParent(this, index);
    }

    internal ISwiftNode? SetChildForciblyAt(int index, ISwiftNode newNode, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
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

    internal void SetChildForciblyAtAndDiscard(int index, ISwiftNode newNode, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Children.Count)
        {
            AppendChildForcibly(newNode, onChildAttachment);
            return;
        }

        ISwiftNode previousChild = Children[index];
        onChildDetachment(previousChild);

        DetachChildForcibly(index);
        newNode.AttachToParent(this, index);
        onChildAttachment(newNode);
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

    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes)
    {
        ClearChildrenForcibly();

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        ClearChildrenForcibly(onChildDetachment);

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
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
    
    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection)
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

        ClearChildrenForcibly();
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
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
        ClearChildrenForcibly(onChildDetachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
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

        ClearChildrenForcibly(onChildDetachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (startInCollection == endInCollection)
        {
            return [..Children];
        }

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

    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (startInCollection == endInCollection)
        {
            return;
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildAttachment, Action<ISwiftNode> onChildDetachment)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (startInCollection == endInCollection)
        {
            return [..Children];
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildAttachment, Action<ISwiftNode> onChildDetachment)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (startInCollection == endInCollection)
        {
            return;
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly, onChildAttachment);
    }

    internal List<ISwiftNode> SetChildrenForciblyWithRange(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection == endInCollection)
        {
            return [..Children];
        }

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

    internal void SetChildrenForciblyWithRangeAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection == endInCollection)
        {
            return;
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForciblyWithRange(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildAttachment, Action<ISwiftNode> onChildDetachment)
    {
        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection == endInCollection)
        {
            return [..Children];
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyWithRangeAndDiscard(IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildAttachment, Action<ISwiftNode> onChildDetachment)
    {
        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection == endInCollection)
        {
            return;
        }

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

        List<ISwiftNode> newChildren = [enumerator.Current!];

        while (collectionIndex < endInCollection && enumerator.MoveNext())
        {
            newChildren.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newChildren, 0, newChildren.Count, AttachChildForcibly, onChildAttachment);
    }

    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes)
    {
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);
    }

    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes, int startInCollection)
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

    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly(IList<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection)
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
    
    internal void SetChildrenForciblyWithRangeAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }
        
        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyWithRangeAndDiscard(IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }

    

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes)
    {
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);
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

    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes, int startInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int count)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly(List<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
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
    
    internal void SetChildrenForciblyWithRangeAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int endInCollection)
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }
        
        if (endInCollection < 0 || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange(List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyWithRangeAndDiscard(List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
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

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }

    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, 0, newNodes.Count, AttachChildForcibly, onChildAttachment);
    }

    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes, int startInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes, int startInCollection)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly);
    }

    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }

    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, newNodes.Count, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes, int startInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int count)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForcibly<TList, TListElements>(TList newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int count,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (startInCollection < 0 || startInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        int endInCollection = startInCollection + count;
        if (endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection)
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

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyWithRangeAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection)
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

        ClearChildrenForcibly();
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly);
    }
    
    internal List<ISwiftNode> SetChildrenForciblyWithRange<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection,
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

        List<ISwiftNode> oldChildren = [..Children];
        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);

        return oldChildren;
    }
    
    internal void SetChildrenForciblyWithRangeAndDiscard<TList, TListElements>(TList newNodes, int startInCollection, int endInCollection,
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

        ClearChildrenForcibly(onChildDetachment);
        AttachChildrenUnchecked<TList, TListElements>(0, newNodes, startInCollection, endInCollection, AttachChildForcibly, onChildAttachment);
    }
}