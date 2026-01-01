using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeInheritanceClauses;

public class TypeIdentifierList : SwiftInternalNode, IList<TypeIdentifierListElement>
{
    private List<TypeIdentifierListElement> _typeIdentifiers = [];

    private List<Comma> _commas = []; 
    
    public TypeIdentifierList(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierList(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierList(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeIdentifierList(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<TypeIdentifierListElement> TypeIdentifiers => _typeIdentifiers;

    public IReadOnlyList<Comma> Commas => _commas;
    
    public IEnumerator<TypeIdentifierListElement> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(TypeIdentifierListElement item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(TypeIdentifierListElement item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(TypeIdentifierListElement[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TypeIdentifierListElement item)
    {
        throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(TypeIdentifierListElement item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, TypeIdentifierListElement item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public TypeIdentifierListElement this[int index]
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}