using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;

public class RawValueStyleMembers : SwiftCompositeNode, IRawValueStyleMembers
{
    private readonly List<IMember> _members;

    internal RawValueStyleMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IMember> Members => _members;

    IReadOnlyList<IReadOnlySwitchCaseMember> IReadOnlyRawValueStyleMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlySwitchCaseMember IReadOnlyList<IReadOnlySwitchCaseMember>.this[int index]
        => _members[index];

    IReadOnlySwitchCaseMember IReadOnlyRawValueStyleMembers.this[int index]
        => _members[index];
    
    public IEnumerator<IMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlySwitchCaseMember> IEnumerable<IReadOnlySwitchCaseMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IMember item)
    {
        return _members.Contains(item);
    }

    public int IndexOf(IMember item)
    {
        return _members.IndexOf(item);
    }

    public void CopyTo(IMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public void Add(IMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
