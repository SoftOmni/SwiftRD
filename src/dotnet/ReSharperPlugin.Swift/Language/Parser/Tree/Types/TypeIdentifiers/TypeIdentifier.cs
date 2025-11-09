using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeIdentifiers;

public class TypeIdentifier : TypeInternalNode, IList<TypeIdentifierComponent>
{
    private List<TypeIdentifierComponent> _components = [];

    public TypeIdentifier(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifier(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifier(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeIdentifier(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<TypeIdentifierComponent> Components => _components;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<TypeIdentifierComponent> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(TypeIdentifierComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(TypeIdentifierComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(TypeIdentifierComponent[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(TypeIdentifierComponent item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(TypeIdentifierComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, TypeIdentifierComponent item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public TypeIdentifierComponent this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}