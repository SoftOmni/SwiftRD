using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

public class SwitchExpression : ConditionalExpression, IList<SwitchExpressionCase>
{
    public Switch? Switch { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }

    private List<SwitchExpressionCase> _cases = [];
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public SwitchExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SwitchExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SwitchExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<SwitchExpressionCase> Cases => _cases;
    public IEnumerator<SwitchExpressionCase> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(SwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(SwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(SwitchExpressionCase[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(SwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(SwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, SwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public SwitchExpressionCase this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}