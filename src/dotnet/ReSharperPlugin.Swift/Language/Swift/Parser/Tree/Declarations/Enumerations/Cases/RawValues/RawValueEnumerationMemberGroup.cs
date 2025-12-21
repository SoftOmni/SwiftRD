using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

public class RawValueEnumerationMemberGroup : SwiftInternalNode, IList<RawValueEnumerationMember>
{
    private List<RawValueEnumerationMember> _rawValueEnumerationMembers = [];
    
    public RawValueEnumerationMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueEnumerationMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueEnumerationMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public RawValueEnumerationMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<RawValueEnumerationMember> RawValueEnumerationMembers => _rawValueEnumerationMembers;

    public IEnumerator<RawValueEnumerationMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(RawValueEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(RawValueEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(RawValueEnumerationMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(RawValueEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(RawValueEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, RawValueEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public RawValueEnumerationMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}