using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.LeafNodes;

public abstract class LeafNode : LeafElementBase, ILeafNode
{
    protected IEditableBuffer UnderlyingBuffer;

    protected InternalNode? ParentNode;

    protected LeafNode(IEditableBuffer underlyingBuffer)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = null;
        ParentIndex = -1;
        ParentTextIndex = -1;
    }

    protected LeafNode(IEditableBuffer underlyingBuffer, InternalNode parentNode, int parentIndex, int parentTextIndex)
    {
        UnderlyingBuffer = underlyingBuffer;
        ParentNode = parentNode;
        ParentIndex = parentIndex;
        ParentTextIndex = parentTextIndex;
    }

    public IInternalNode? GetParent() => ParentNode;

    public bool HasParent() => ParentNode is not null;

    public int ParentIndex { get; private set; }
    
    public int ParentTextIndex { get; private set; }
    
    public IBuffer Buffer => UnderlyingBuffer;

    public abstract INode CloneAsDetached();

    public abstract INode CloneAsAttachedTo(IInternalNode newParent, int index);

    public void AttachToParent(IInternalNode newParent, int parentIndex)
    {
        newParent.AttachChild(parentIndex, this);
    }

    public void DetachFromParent()
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
}