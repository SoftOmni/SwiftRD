using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actors;

public class ActorMemberGroup : SwiftInternalNode, IList<IActorMember>
{
    private List<IActorMember> _actorMembers = [];

    public ActorMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ActorMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ActorMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ActorMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IActorMember> Members => _actorMembers;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<IActorMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IActorMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IActorMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IActorMember item)
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

    public IActorMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}