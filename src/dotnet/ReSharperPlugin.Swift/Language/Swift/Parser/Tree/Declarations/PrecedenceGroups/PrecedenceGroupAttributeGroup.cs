using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public class PrecedenceGroupAttributeGroup : SwiftInternalNode, IList<PrecedenceGroupAttribute>
{
    private List<PrecedenceGroupAttribute> _attributes = [];

    public PrecedenceGroupAttributeGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAttributeGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAttributeGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrecedenceGroupAttributeGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<PrecedenceGroupAttribute> Attributes => _attributes;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<PrecedenceGroupAttribute> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(PrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(PrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(PrecedenceGroupAttribute[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(PrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(PrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, PrecedenceGroupAttribute item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public PrecedenceGroupAttribute this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}