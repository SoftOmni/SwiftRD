using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members;

public class SwitchCaseMembers : SwiftCompositeNode, ISwitchCaseMembers
{
    private readonly List<ISwitchCaseMember> _members;

    internal SwitchCaseMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<ISwitchCaseMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<ISwitchCaseMember> Members => _members;

    IReadOnlyList<IReadOnlySwitchCaseMember> IReadOnlySwitchCaseMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new ISwitchCaseMember this[int index]
    {
        get => _members[index];
        set => throw new NotImplementedException();
    }

    IReadOnlySwitchCaseMember IReadOnlyList<IReadOnlySwitchCaseMember>.this[int index]
        => _members[index];

    IReadOnlySwitchCaseMember IReadOnlySwitchCaseMembers.this[int index]
        => _members[index];
    
    public IEnumerator<ISwitchCaseMember> GetEnumerator()
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

    public bool Contains(ISwitchCaseMember item)
    {
        return _members.Contains(item);
    }

    public int IndexOf(ISwitchCaseMember item)
    {
        return _members.IndexOf(item);
    }

    public void CopyTo(ISwitchCaseMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public void Add(ISwitchCaseMember item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ISwitchCaseMember item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ISwitchCaseMember item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
