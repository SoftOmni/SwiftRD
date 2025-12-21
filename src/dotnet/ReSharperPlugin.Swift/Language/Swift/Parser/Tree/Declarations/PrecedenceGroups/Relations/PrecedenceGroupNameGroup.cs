using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public class PrecedenceGroupNameGroup : SwiftInternalNode, IList<Identifier>
{
    private List<Identifier> _identifiers = [];

    public PrecedenceGroupNameGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupNameGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupNameGroup(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrecedenceGroupNameGroup(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<Identifier> Identifiers => _identifiers;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<Identifier> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(Identifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(Identifier item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(Identifier[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(Identifier item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(Identifier item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, Identifier item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public Identifier this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}