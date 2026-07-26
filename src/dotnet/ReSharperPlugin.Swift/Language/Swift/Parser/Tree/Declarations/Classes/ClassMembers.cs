using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public class ClassMembers : SwiftCompositeNode, IClassMembers
{
    private readonly List<IClassMember> _members;

    internal ClassMembers(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IClassMember> members)
        : base(buffer, children)
    {
        _members = members;
    }

    public IReadOnlyList<IClassMember> Members => _members;

    IReadOnlyList<IReadOnlyClassMember> IReadOnlyClassMembers.Members => Members;

    public int Count => _members.Count;

    public bool IsReadOnly => false;

    public new IClassMember this[int index]
    {
        get => _members[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyClassMember IReadOnlyList<IReadOnlyClassMember>.this[int index]
        => _members[index];

    IReadOnlyClassMember IReadOnlyClassMembers.this[int index]
        => _members[index];

    public IEnumerator<IClassMember> GetEnumerator()
    {
        return _members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyClassMember> IEnumerable<IReadOnlyClassMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IClassMember item)
    {
        return _members.Contains(item);
    }

    public void CopyTo(IClassMember[] array, int arrayIndex)
    {
        _members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IClassMember item)
    {
        return _members.IndexOf(item);
    }

    public void Add(IClassMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IClassMember item)
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
}
