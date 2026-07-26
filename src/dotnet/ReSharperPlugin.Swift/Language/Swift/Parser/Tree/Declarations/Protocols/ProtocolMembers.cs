using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public class ProtocolMembers : SwiftCompositeNode, IProtocolMembers
{
    private readonly List<IProtocolMember> _members;

    internal ProtocolMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IProtocolMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IProtocolMember> Members => _members;

    IReadOnlyList<IReadOnlyProtocolMember> IReadOnlyProtocolMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IProtocolMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyProtocolMember IReadOnlyList<IReadOnlyProtocolMember>.this[int index]
        => _members[index];

    IReadOnlyProtocolMember IReadOnlyProtocolMembers.this[int index]
        => _members[index];

    public IEnumerator<IProtocolMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyProtocolMember> IEnumerable<IReadOnlyProtocolMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IProtocolMember item)
    {
        return _members.Contains(item);
    }

    public void CopyTo(IProtocolMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IProtocolMember item)
    {
        return _members.IndexOf(item);
    }

    public void Add(IProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
