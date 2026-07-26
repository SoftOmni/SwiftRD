using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public class RawValueStyleEnumCaseClause : SwiftCompositeNode, IRawValueStyleEnumCaseClause
{
    public IAttributeGroup? Attributes { get; }

    public Case Case { get; }

    private readonly List<IRawValueStyleEnumCase> _cases;

    private readonly List<Comma> _caseSeparators;

    internal RawValueStyleEnumCaseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, Case @case, List<IRawValueStyleEnumCase> cases, List<Comma> caseSeparators)
        : base(buffer, children)
    {
        Attributes = attributes;
        Case = @case;
        _cases = cases;
        _caseSeparators = caseSeparators;
    }

    internal RawValueStyleEnumCaseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Case @case, List<IRawValueStyleEnumCase> cases, List<Comma> caseSeparators)
        : base(buffer, children)
    {
        Case = @case;
        _cases = cases;
        _caseSeparators = caseSeparators;
    }

    IReadOnlyAttributeGroup? IReadOnlyRawValueStyleEnumCaseClause.Attributes => Attributes;

    public IReadOnlyList<IRawValueStyleEnumCase> Cases => _cases;

    IReadOnlyList<IReadOnlyRawValueStyleEnumCase> IReadOnlyRawValueStyleEnumCaseClause.Cases => Cases;

    public IReadOnlyList<Comma> CaseSeparators => _caseSeparators;

    public int Count => _cases.Count;

    public bool IsReadOnly => false;

    public new IRawValueStyleEnumCase this[int index]
    {
        get => _cases[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyRawValueStyleEnumCase IReadOnlyList<IReadOnlyRawValueStyleEnumCase>.this[int index]
        => _cases[index];

    IReadOnlyRawValueStyleEnumCase IReadOnlyRawValueStyleEnumCaseClause.this[int index]
        => _cases[index];

    public IEnumerator<IRawValueStyleEnumCase> GetEnumerator()
    {
        return _cases.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyRawValueStyleEnumCase> IEnumerable<IReadOnlyRawValueStyleEnumCase>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IRawValueStyleEnumCase item)
    {
        return _cases.Contains(item);
    }

    public int IndexOf(IRawValueStyleEnumCase item)
    {
        return _cases.IndexOf(item);
    }

    public void CopyTo(IRawValueStyleEnumCase[] array, int arrayIndex)
    {
        _cases.CopyTo(array, arrayIndex);
    }

    public void Add(IRawValueStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IRawValueStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IRawValueStyleEnumCase item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
