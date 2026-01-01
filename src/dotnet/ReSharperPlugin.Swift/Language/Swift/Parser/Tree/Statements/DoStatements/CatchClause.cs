using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.DoStatements;

public class CatchClause : SwiftInternalNode, IList<CatchPattern>
{
    public Catch? Catch { get; internal set; }

    private List<CatchPattern> _patterns = [];

    public CatchClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CatchClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CatchClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CatchClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<CatchPattern> Patterns => _patterns;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<CatchPattern> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(CatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(CatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(CatchPattern[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(CatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(CatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, CatchPattern item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public CatchPattern this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}