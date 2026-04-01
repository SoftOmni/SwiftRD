using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

public class DeclarationModifierGroup : SwiftInternalNode, IList<IDeclarationModifier>
{
    private List<IDeclarationModifier> DeclarationModifiersUnderlying { get; } = [];
    
    public DeclarationModifierGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DeclarationModifierGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DeclarationModifierGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DeclarationModifierGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IDeclarationModifier> DeclarationModifiers => DeclarationModifiersUnderlying;

    public IEnumerator<IDeclarationModifier> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IDeclarationModifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IDeclarationModifier item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IDeclarationModifier[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IDeclarationModifier item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IDeclarationModifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IDeclarationModifier item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IDeclarationModifier this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}