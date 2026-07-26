using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.DoStatements.CatchClauses;

public class CatchClauseList : SwiftCompositeNode, ICatchClauseList
{
    private readonly List<ICatchClause> _catchClauses;

    internal CatchClauseList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        List<ICatchClause> catchClauses)
        : base(buffer, children)
    {
        _catchClauses = catchClauses;
    }

    public IReadOnlyList<ICatchClause> CatchClauses => _catchClauses;

    IReadOnlyList<IReadOnlyCatchClause> IReadOnlyCatchClauseList.CatchClauses => CatchClauses;

    public int Count => _catchClauses.Count;

    public bool IsReadOnly => false;

    public new ICatchClause this[int index]
    {
        get => _catchClauses[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyCatchClause IReadOnlyList<IReadOnlyCatchClause>.this[int index] =>
        _catchClauses[index];

    IReadOnlyCatchClause IReadOnlyCatchClauseList.this[int index] =>
        _catchClauses[index];

    public IEnumerator<ICatchClause> GetEnumerator()
    {
        return _catchClauses.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyCatchClause> IEnumerable<IReadOnlyCatchClause>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ICatchClause item)
    {
        return _catchClauses.Contains(item);
    }

    public int IndexOf(ICatchClause item)
    {
        return _catchClauses.IndexOf(item);
    }

    public void CopyTo(ICatchClause[] array, int arrayIndex)
    {
        _catchClauses.CopyTo(array, arrayIndex);
    }

    public void Add(ICatchClause item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ICatchClause item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ICatchClause item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
