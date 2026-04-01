using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public class ClassMemberGroup : SwiftInternalNode, IList<IClassMember>
{
    private List<IClassMember> _classMembers = [];

    public ClassMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ClassMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ClassMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ClassMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IClassMember> Members => _classMembers;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<IClassMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IClassMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public IClassMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}