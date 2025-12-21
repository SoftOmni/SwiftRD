using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.CaseLabels;

public class CaseLabelCase : SwitchCase, IList<CaseItem>
{
    public AttributeGroup? Attributes { get; internal set; }
    
    public Case? Case { get; internal set; }

    private List<CaseItem> _caseItems = [];
    
    public StatementGroup? Statements{ get; internal set; }
    
    public CaseLabelCase(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaseLabelCase(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CaseLabelCase(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CaseLabelCase(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<CaseItem> CaseItems => _caseItems;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<CaseItem> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(CaseItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(CaseItem item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(CaseItem[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(CaseItem item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(CaseItem item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, CaseItem item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public CaseItem this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}