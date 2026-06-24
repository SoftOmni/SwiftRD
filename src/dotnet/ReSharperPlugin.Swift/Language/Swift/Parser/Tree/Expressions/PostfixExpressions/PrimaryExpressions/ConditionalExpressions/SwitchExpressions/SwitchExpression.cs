using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.SwitchExpressions;

public class SwitchExpression : SwiftCompositeNode, ISwitchExpression
{
    public Switch Switch { get; }

    public IExpression Expression { get; }
    
    public LeftCurlyBrace LeftCurlyBrace { get; }

    private readonly List<ISwitchExpressionCase> _cases;

    public RightCurlyBrace RightCurlyBrace { get; }

    internal SwitchExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Switch @switch, IExpression expression, LeftCurlyBrace leftCurlyBrace, List<ISwitchExpressionCase> cases,
        RightCurlyBrace rightCurlyBrace)
        : base(buffer, children)
    {
        Switch = @switch;
        Expression = expression;
        LeftCurlyBrace = leftCurlyBrace;
        _cases = cases;
        RightCurlyBrace = rightCurlyBrace;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyExpression IReadOnlySwitchExpression.Expression => Expression;

    public IReadOnlyList<ISwitchExpressionCase> Cases => _cases;

    IReadOnlyList<IReadOnlySwitchExpressionCase> IReadOnlySwitchExpression.Cases => Cases;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public int Count => _cases.Count;

    public bool IsReadOnly => false;

    public new ISwitchExpressionCase this[int index]
    {
        get => _cases[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlySwitchExpressionCase IReadOnlyList<IReadOnlySwitchExpressionCase>.this[int index]
        => _cases[index];

    public IEnumerator<ISwitchExpressionCase> GetEnumerator()
    {
        return _cases.GetEnumerator();
    }

    IEnumerator<IReadOnlySwitchExpressionCase> IEnumerable<IReadOnlySwitchExpressionCase>.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(ISwitchExpressionCase item)
    {
        return _cases.Contains(item);
    }

    public int IndexOf(ISwitchExpressionCase item)
    {
        return _cases.IndexOf(item);
    }

    public void CopyTo(ISwitchExpressionCase[] array, int arrayIndex)
    {
        _cases.CopyTo(array, arrayIndex);
    }

    public void Add(ISwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ISwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ISwitchExpressionCase item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
