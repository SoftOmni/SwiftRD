using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionStyle;

public class UnionStyleEnumCaseClause : SwiftCompositeNode, IUnionStyleEnumCaseClause
{
    public IAttributeGroup? Attributes { get; }

    public Indirect? IndirectKeyword { get; }

    public Case CaseKeyword { get; }

    private readonly List<IUnionStyleEnumCase> _cases;

    private readonly List<Comma> _caseSeparators;

    internal UnionStyleEnumCaseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, Indirect? indirectKeyword, Case caseKeyword,
        List<IUnionStyleEnumCase> cases, List<Comma> caseSeparators)
        : base(buffer, children)
    {
        Attributes = attributes;
        IndirectKeyword = indirectKeyword;
        CaseKeyword = caseKeyword;
        _cases = cases;
        _caseSeparators = caseSeparators;
    }

    public IReadOnlyList<IUnionStyleEnumCase> Cases => _cases;

    public IReadOnlyList<Comma> CaseSeparators => _caseSeparators;

    IReadOnlyAttributeGroup? IReadOnlyUnionStyleEnumCaseClause.Attributes => Attributes;

    IReadOnlyList<IReadOnlyUnionStyleEnumCase> IReadOnlyUnionStyleEnumCaseClause.Cases => Cases;

    public int Count => _cases.Count;

    public bool IsReadOnly => false;

    public new IUnionStyleEnumCase this[int index]
    {
        get => _cases[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyUnionStyleEnumCase IReadOnlyList<IReadOnlyUnionStyleEnumCase>.this[int index]
        => _cases[index];

    IReadOnlyUnionStyleEnumCase IReadOnlyUnionStyleEnumCaseClause.this[int index]
        => _cases[index];

    public IEnumerator<IUnionStyleEnumCase> GetEnumerator()
    {
        return _cases.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyUnionStyleEnumCase> IEnumerable<IReadOnlyUnionStyleEnumCase>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public bool Contains(IUnionStyleEnumCase item)
    {
        return _cases.Contains(item);
    }

    public void CopyTo(IUnionStyleEnumCase[] array, int arrayIndex)
    {
        _cases.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IUnionStyleEnumCase item)
    {
        return _cases.IndexOf(item);
    }

    public void Add(IUnionStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IUnionStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IUnionStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
