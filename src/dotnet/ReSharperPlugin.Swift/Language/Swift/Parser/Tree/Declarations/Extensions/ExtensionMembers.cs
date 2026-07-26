using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class ExtensionMembers : SwiftCompositeNode, IExtensionMembers
{
    private readonly List<IExtensionMember> _members;

    internal ExtensionMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IExtensionMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IExtensionMember> Members => _members;

    IReadOnlyList<IReadOnlyExtensionMember> IReadOnlyExtensionMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IExtensionMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyExtensionMember IReadOnlyList<IReadOnlyExtensionMember>.this[int index]
        => _members[index];

    IReadOnlyExtensionMember IReadOnlyExtensionMembers.this[int index]
        => _members[index];

    public IEnumerator<IExtensionMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyExtensionMember> IEnumerable<IReadOnlyExtensionMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IExtensionMember item)
    {
        return _members.Contains(item);
    }

    public void CopyTo(IExtensionMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IExtensionMember item)
    {
        return _members.IndexOf(item);
    }

    public void Add(IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
