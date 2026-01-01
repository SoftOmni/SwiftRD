using System;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Constrained.Root;

public abstract class Node<TInternalNode, TLeafNode> : TreeElement, 
    INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>>
    where TInternalNode : class, IInternalNode<Node<TInternalNode, TLeafNode>>
    where TLeafNode : ILeafNode<Node<TInternalNode, TLeafNode>>
{
    protected IEditableBuffer UnderlyingBuffer;

    protected TInternalNode? ParentNode;

    protected Node(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected Node(IEditableBuffer underlyingBuffer, TInternalNode parentNode, int parentIndex, int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }
    
    public IInternalNode? GetParent()
    {
        return ParentNode;
    }

    INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>> INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>> INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>>.CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(IInternalNode<Node<TInternalNode, TLeafNode>> newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    IInternalNode<Node<TInternalNode, TLeafNode>>? INode<IInternalNode<Node<TInternalNode, TLeafNode>>, ILeafNode<Node<TInternalNode, TLeafNode>>>.GetParent()
    {
        throw new NotImplementedException();
    }

    public bool HasParent() => ParentNode is not null;

    public int ParentIndex { get; private set; }
    
    public int ParentTextIndex { get; private set; }
    
    public IBuffer Buffer => UnderlyingBuffer;

    public abstract INode CloneAsDetached();

    public abstract INode CloneAsAttachedTo(IInternalNode newParent, int index);

    public virtual void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        if (!newParent.GetType().IsAssignableFrom(typeof(TInternalNode)))
        {
            throw new NotSupportedException($"The type of new parent ({newParent.GetType().FullName} (runtime type))\n" +
                                            $"is not assignable to the type of {typeof(TInternalNode).FullName}.\n" +
                                            "This is required for a constrained Node<TInternalNode, TLeafNode>.");
        }
        
        newParent.AttachChild(parentIndex, this);
    }

    public void AttachToParent(TInternalNode newParent, int parentIndex)
    {
        newParent.AttachChild<Node<TInternalNode, TLeafNode>>(ParentIndex, this);
    }

    public virtual void DetachFromParent()
    {
        IEditableBuffer newBuffer = new EditableBuffer(UnderlyingBuffer.Length);
        for (int i = 0; i < UnderlyingBuffer.Length; i++)
        {
            newBuffer.Insert(i, UnderlyingBuffer[i].ToString());
        }
        
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
        UnderlyingBuffer = newBuffer;
    }

    public abstract override PsiLanguageType Language { get; }
}