using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Protocols;

public class ProtocolMemberGroup : SwiftInternalNode, IList<ProtocolMember>
{
    private List<ProtocolMember> _protocolMembers = [];

    public ProtocolMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolMemberGroup(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ProtocolMemberGroup(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<ProtocolMember> Members => _protocolMembers;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<ProtocolMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(ProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(ProtocolMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(ProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ProtocolMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public ProtocolMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}