using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeIdentifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.ProtocolCompositionType;

public class ProtocolCompositionType : SwiftInternalNode, IList<TypeIdentifier>, IReadOnlyList<Ampersand>
{
    private List<TypeIdentifier> _typeIdentifiers = [];

    private List<Ampersand> _ampersands = [];

    public ProtocolCompositionType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolCompositionType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolCompositionType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ProtocolCompositionType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<TypeIdentifier> TypeIdentifiers => _typeIdentifiers;

    public IReadOnlyList<Ampersand> Ampersands => _ampersands;

    public int TypeIdentifiersCount => _typeIdentifiers.Count;

    public int Count => NumberOfChildren();

    public int AmpersandsCount => _ampersands.Count;

    public bool IsReadOnly => false;

    TypeIdentifier IList<TypeIdentifier>.this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }

    Ampersand IReadOnlyList<Ampersand>.this[int index] => throw new System.NotImplementedException();

    public TypeIdentifier GetTypeIdentifierAtIndex(int index)
    {
        throw new NotImplementedException();
    }

    public TypeIdentifier GetAmpersandAtIndex(int index)
    {
        throw new NotImplementedException();
    }
    
    public void SetTypeIdentifierAtIndex(int index, TypeIdentifier newTypeIdentifier)
    {
        throw new NotImplementedException();
    }

    void ICollection<TypeIdentifier>.Clear()
    {
        throw new NotImplementedException();
    }

    public void Add(TypeIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, TypeIdentifier item)
    {
        throw new NotImplementedException();
    }

    void IList<TypeIdentifier>.RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TypeIdentifier item)
    {
        throw new NotImplementedException();
    }

    public bool Contains(TypeIdentifier item)
    {
        throw new NotImplementedException();
    }

    public bool Contains(Ampersand item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(TypeIdentifier[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(Ampersand[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(TypeIdentifier item)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(Ampersand item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<TypeIdentifier> IEnumerable<TypeIdentifier>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<Ampersand> IEnumerable<Ampersand>.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}