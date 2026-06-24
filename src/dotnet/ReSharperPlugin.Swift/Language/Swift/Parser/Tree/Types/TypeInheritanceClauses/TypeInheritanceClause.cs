using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public class TypeInheritanceClause : SwiftCompositeNode, ITypeInheritanceClause
{
    public Colon Colon { get; }
    
    private readonly List<ITypeInheritanceListElement> _elements;

    private readonly List<Comma> _commas;


    internal TypeInheritanceClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Colon colon, List<ITypeInheritanceListElement> elements, List<Comma> commas)
        : base(buffer, children)
    {
        Colon = colon;
        _elements = elements;
        _commas = commas;
    }

    public IReadOnlyList<IReadOnlyTypeInheritanceListElement> Elements => _elements;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _elements.Count;

    public bool IsReadOnly => false;

    public new ITypeInheritanceListElement this[int index]
    {
        get => _elements[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyTypeInheritanceListElement IReadOnlyTypeInheritanceClause.this[int index] => _elements[index];

    IReadOnlyTypeInheritanceListElement IReadOnlyList<IReadOnlyTypeInheritanceListElement>.this[int index] =>
        _elements[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator<IReadOnlyTypeInheritanceListElement> IEnumerable<IReadOnlyTypeInheritanceListElement>.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator<ITypeInheritanceListElement> IEnumerable<ITypeInheritanceListElement>.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator<ITypeInheritanceListElement> ITypeInheritanceClause.GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    public void Add(ITypeInheritanceListElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ITypeInheritanceListElement item)
    {
        return _elements.Contains(item);
    }

    public void CopyTo(ITypeInheritanceListElement[] array, int arrayIndex)
    {
        _elements.CopyTo(array, arrayIndex);
    }

    public bool Remove(ITypeInheritanceListElement item)
    {
        throw new System.NotImplementedException();
    }

    public int IndexOf(ITypeInheritanceListElement item)
    {
        return _elements.IndexOf(item);
    }

    public void Insert(int index, ITypeInheritanceListElement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}