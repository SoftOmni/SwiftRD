using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structures;

public class StructMemberGroup : SwiftInternalNode, IList<IStructMember>
{
    private List<IStructMember> _structMembers = [];
    
    public StructMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public StructMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public StructMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public StructMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IStructMember> StructMembers => _structMembers;

    public IEnumerator<IStructMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IStructMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IStructMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}