using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.
    GenericSwitchCases;

public class CaseLabel : SwiftCompositeNode, ICaseLabel
{
    public IAttributeGroup? AttributeGroup { get; }

    public Case Case { get; }

    public ICaseItemList CaseItemList { get; }

    public Colon StatementsStartColon { get; }

    internal CaseLabel(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Case @case, ICaseItemList caseItemList, Colon statementsStartColon)
        : base(buffer, children)
    {
        Case = @case;
        CaseItemList = caseItemList;
        StatementsStartColon = statementsStartColon;
    }

    internal CaseLabel(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup attributeGroup, Case @case, ICaseItemList caseItemList, Colon statementsStartColon)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Case = @case;
        CaseItemList = caseItemList;
        StatementsStartColon = statementsStartColon;
    }

    IReadOnlyAttributeGroup? IReadOnlyCaseLabel.AttributeGroup => AttributeGroup;

    IReadOnlyCaseItemList IReadOnlyCaseLabel.CaseItemList => CaseItemList;

    public IReadOnlyList<(IPattern pattern, IWhereClause? whereClause)> CaseItems => CaseItemList.CaseItems;

    IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> IReadOnlyCaseLabel.CaseItems =>
        (CaseItemList as IReadOnlyCaseItemList).CaseItems;

    public int Count => CaseItemList.Count;

    public bool IsReadOnly => CaseItemList.IsReadOnly;

    public new (IPattern pattern, IWhereClause? whereClause) this[int index]
    {
        get => CaseItemList[index];
        set
        {
            CaseItemList.SetPatternAt(index, value.pattern);
            CaseItemList.SetWhereClauseAt(index, value.whereClause);
        }
    }

    (IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)
        IReadOnlyList<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>.this[int index]
        => CaseItemList[index];

    (IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause) IReadOnlyCaseLabel.this[int index]
        => CaseItemList[index];

    public IEnumerator<(IPattern pattern, IWhereClause? whereClause)> GetEnumerator()
    {
        return CaseItemList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)> IEnumerable<(IReadOnlyPattern pattern, IReadOnlyWhereClause? whereClause)>.GetEnumerator()
    {
        return (CaseItemList as IReadOnlyCaseItemList).GetEnumerator();
    }

    public bool Contains((IPattern pattern, IWhereClause? whereClause) item)
    {
        return CaseItemList.Contains(item);
    }

    public int IndexOf((IPattern pattern, IWhereClause? whereClause) item)
    {
        return CaseItemList.IndexOf(item);
    }

    public void CopyTo((IPattern pattern, IWhereClause? whereClause)[] array, int arrayIndex)
    {
        CaseItemList.CopyTo(array, arrayIndex);
    }

    public void Add((IPattern pattern, IWhereClause? whereClause) item)
    {
        CaseItemList.Add(item);
    }

    public void Clear()
    {
        CaseItemList.Clear();
    }

    public bool Remove((IPattern pattern, IWhereClause? whereClause) item)
    {
        return CaseItemList.Remove(item);
    }

    public void Insert(int index, (IPattern pattern, IWhereClause? whereClause) item)
    {
        CaseItemList.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        CaseItemList.RemoveAt(index);
    }

    public void SetPatternAt(int index, IPattern newPattern)
    {
        CaseItemList.SetPatternAt(index, newPattern);
    }

    public void SetWhereClauseAt(int index, IWhereClause? newWhereClause)
    {
        CaseItemList.SetWhereClauseAt(index, newWhereClause);
    }

    public void RemoveWhereClauseAt(int index)
    {
        CaseItemList.RemoveWhereClauseAt(index);
    }
}
