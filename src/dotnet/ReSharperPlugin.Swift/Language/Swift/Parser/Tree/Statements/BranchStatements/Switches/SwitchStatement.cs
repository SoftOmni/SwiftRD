using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches;

public class SwitchStatement : BranchStatement, IList<SwitchCase>
{
    public Switch? Switch { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }

    public SwitchCaseGroup? SwitchCaseGroup { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public SwitchStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SwitchStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public override bool AllowsBreakStatements => true;

    public IReadOnlyList<SwitchCase> SwitchCases => SwitchCaseGroup?.Cases ?? [];
    
    public IEnumerator<SwitchCase> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(SwitchCase[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, SwitchCase item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public SwitchCase this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}