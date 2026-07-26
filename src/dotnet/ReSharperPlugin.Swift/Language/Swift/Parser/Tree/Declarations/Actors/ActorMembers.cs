using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actorures;

public class ActorMembers : SwiftCompositeNode, IActorMembers
{
    private readonly List<IActorMember> _members;

    internal ActorMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IActorMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IActorMember> Members => _members;

    IReadOnlyList<IReadOnlyActorMember> IReadOnlyActorMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IActorMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyActorMember IReadOnlyList<IReadOnlyActorMember>.this[int index]
        => _members[index];

    IReadOnlyActorMember IReadOnlyActorMembers.this[int index]
        => _members[index];

    public IEnumerator<IActorMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyActorMember> IEnumerable<IReadOnlyActorMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IActorMember item)
    {
        return _members.Contains(item);
    }

    public void CopyTo(IActorMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IActorMember item)
    {
        return _members.IndexOf(item);
    }

    public void Add(IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
