using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

public class RawValueStyleEnumCaseClause : SwiftInternalNode, IRawValueEnumerationMember, IList<RawValueStyleEnumCase>
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public Case? Case { get; internal set; }

    private List<RawValueStyleEnumCase> _enumCases = [];
    
    public RawValueStyleEnumCaseClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueStyleEnumCaseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueStyleEnumCaseClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public RawValueStyleEnumCaseClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<RawValueStyleEnumCase> EnumCases => _enumCases;

    public IEnumerator<RawValueStyleEnumCase> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(RawValueStyleEnumCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(RawValueStyleEnumCase item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(RawValueStyleEnumCase[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(RawValueStyleEnumCase item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(RawValueStyleEnumCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, RawValueStyleEnumCase item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public RawValueStyleEnumCase this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}