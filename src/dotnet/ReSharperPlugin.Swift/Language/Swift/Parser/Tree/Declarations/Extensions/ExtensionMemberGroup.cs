using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class ExtensionMemberGroup : SwiftInternalNode, IList<IExtensionMember>
{
    private List<IExtensionMember> _extensionMembers = [];

    public ExtensionMemberGroup(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ExtensionMemberGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ExtensionMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ExtensionMemberGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<IExtensionMember> ExtensionMembers => _extensionMembers;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<IExtensionMember> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(IExtensionMember[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IExtensionMember item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(IExtensionMember item)
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

    public IExtensionMember this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}