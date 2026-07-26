using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

public class IdentifierList : SwiftCompositeNode, IIdentifierList
{
    private List<IIdentifier> _identifiers;

    private List<Comma> _commas;

    internal IdentifierList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IIdentifier> identifiers, List<Comma> commas)
        : base(buffer, children)
    {
        _identifiers = identifiers;
        _commas = commas;
    }
    
    public int Count => _identifiers.Count;

    public bool IsReadOnly => false;

    public IReadOnlyList<IReadOnlyIdentifier> Identifiers => _identifiers;

    public IReadOnlyList<Comma> Commas => _commas;

    IIdentifier IIdentifierList.this[int index] => _identifiers[index];

    IReadOnlyIdentifier IReadOnlyList<IReadOnlyIdentifier>.this[int index] => _identifiers[index];

    IIdentifier IList<IIdentifier>.this[int index]
    {
        get => _identifiers[index];
        set => throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _identifiers.GetEnumerator();
    }

    IEnumerator<IIdentifier> IIdentifierList.GetEnumerator()
    {
        return _identifiers.GetEnumerator();
    }

    IEnumerator<IIdentifier> IEnumerable<IIdentifier>.GetEnumerator()
    {
        return _identifiers.GetEnumerator();
    }

    IEnumerator<IReadOnlyIdentifier> IEnumerable<IReadOnlyIdentifier>.GetEnumerator()
    {
        return _identifiers.GetEnumerator();
    }

    public bool Contains(IIdentifier item)
    {
        return _identifiers.Contains(item);
    }

    public int IndexOf(IIdentifier item)
    {
        return _identifiers.IndexOf(item);
    }

    public void CopyTo(IIdentifier[] array, int arrayIndex)
    {
        _identifiers.CopyTo(array, arrayIndex);
    }

    public void Add(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IIdentifier item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
