using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

public class StructMembers : SwiftCompositeNode, IStructMembers
{
    private readonly List<IStructMember> _members;

    internal StructMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IStructMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IStructMember> Members => _members;

    IReadOnlyList<IReadOnlyStructMember> IReadOnlyStructMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IStructMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyStructMember IReadOnlyList<IReadOnlyStructMember>.this[int index]
        => _members[index];

    IReadOnlyStructMember IReadOnlyStructMembers.this[int index]
        => _members[index];

    public IEnumerator<IStructMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyStructMember> IEnumerable<IReadOnlyStructMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IStructMember item)
    {
        return _members.Contains(item);
    }

    public void CopyTo(IStructMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IStructMember item)
    {
        return _members.IndexOf(item);
    }

    public void Add(IStructMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IStructMember item)
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
}
