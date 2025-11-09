using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.DoStatements;

public class DoStatement : StatementInternalNode, IList<CatchClause>
{
    public Do? Do { get; internal set; }
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    public CodeBlock? CodeBlock { get; internal set; }

    private List<CatchClause> _clauses = [];
    
    public DoStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DoStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DoStatement(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DoStatement(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<CatchClause> CatchClauses => _clauses;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<CatchClause> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(CatchClause item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(CatchClause item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(CatchClause[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(CatchClause item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(CatchClause item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, CatchClause item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public CatchClause this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}