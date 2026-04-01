using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;

public class UnionStyleEnumerationMemberGroup : SwiftInternalNode, IList<UnionStyleEnumerationMember>
{
    private List<UnionStyleEnumerationMember> _unionStyleEnumerationMembers = [];
    
    public UnionStyleEnumerationMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnionStyleEnumerationMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<UnionStyleEnumerationMember> UnionStyleEnumerationMembers => _unionStyleEnumerationMembers;

    public IEnumerator<UnionStyleEnumerationMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(UnionStyleEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(UnionStyleEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(UnionStyleEnumerationMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(UnionStyleEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(UnionStyleEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, UnionStyleEnumerationMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public UnionStyleEnumerationMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}