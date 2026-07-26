using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    GenericSwitchCases;

public class CaseItemList : SwiftCompositeNode, ICaseItemList
{
    private readonly List<(IPattern pattern, IWhereClause? whereClause)> _caseItems;

    private readonly List<Comma> _caseItemSeparators;

    public CaseItemList(IEditableBuffer buffer, IList<ISwiftNode<SwiftCompositeNode>> children,
        List<(IPattern pattern, IWhereClause? whereClause)> caseItems,
        List<Comma> caseItemSeparators)
        : base(buffer, children)
    {
        _caseItems = caseItems;
        _caseItemSeparators = caseItemSeparators;
    }

    public IReadOnlyList<(IPattern pattern, IWhereClause? whereClause)> CaseItems => _caseItems;

    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> IReadOnlyCaseItemList.CaseItems =>
        GenerateReadOnlyList();

    public IReadOnlyList<Comma> CaseItemSeparators => _caseItemSeparators;

    public int Count => _caseItems.Count;

    public bool IsReadOnly => false;

    public new (IPattern pattern, IWhereClause? whereClause) this[int index]
    {
        get => _caseItems[index];
        set => throw new NotImplementedException();
    }

    (IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)
        IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>.this[int index]
        => _caseItems[index];

    public IEnumerator<(IPattern pattern, IWhereClause? whereClause)> GetEnumerator()
    {
        return _caseItems.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> IEnumerable<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Contains((IPattern pattern, IWhereClause? whereClause) item)
    {
        return _caseItems.Contains(item);
    }

    public int IndexOf((IPattern pattern, IWhereClause? whereClause) item)
    {
        return _caseItems.IndexOf(item);
    }

    public void CopyTo((IPattern pattern, IWhereClause? whereClause)[] array, int arrayIndex)
    {
        _caseItems.CopyTo(array, arrayIndex);
    }

    public void Add((IPattern pattern, IWhereClause? whereClause) item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove((IPattern pattern, IWhereClause? whereClause) item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, (IPattern pattern, IWhereClause? whereClause) item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public void SetPatternAt(int index, IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void SetWhereClauseAt(int index, IWhereClause? newWhereClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveWhereClauseAt(int index)
    {
        throw new NotImplementedException();
    }

    private List<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> GenerateReadOnlyList()
    {
        List<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> caseItems = [];

        foreach ((IPattern pattern, IWhereClause? whereClause) caseItem in CaseItems)
        {
            caseItems.Add((caseItem.pattern, caseItem.whereClause));
        }

        return caseItems;
    }
}
