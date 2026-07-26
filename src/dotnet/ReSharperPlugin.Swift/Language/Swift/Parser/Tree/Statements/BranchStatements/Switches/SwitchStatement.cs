using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

public class SwitchStatement : SwiftCompositeNode, ISwitchStatement
{
    public Switch Switch { get; }

    public IExpression ConditionExpression { get; }
    
    public LeftCurlyBrace CasesStartCurlyBrace { get; }

    private readonly List<ISwitchCase> _switchCases;

    public RightCurlyBrace CasesEndCurlyBrace { get; }

    internal SwitchStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Switch @switch,
        IExpression conditionExpression, LeftCurlyBrace casesStartCurlyBrace, List<ISwitchCase> switchCases,
        RightCurlyBrace casesEndCurlyBrace)
        : base(buffer, children)
    {
        _switchCases = switchCases;
        Switch = @switch;
        ConditionExpression = conditionExpression;
        CasesStartCurlyBrace = casesStartCurlyBrace;
        CasesEndCurlyBrace = casesEndCurlyBrace;
    }

    IReadOnlyExpression IReadOnlySwitchStatement.ConditionExpression => ConditionExpression;

    public IReadOnlyList<ISwitchCase> SwitchCases => _switchCases;

    IReadOnlyList<IReadOnlySwitchCase> IReadOnlySwitchStatement.SwitchCases => SwitchCases;

    public int Count => _switchCases.Count;

    public bool IsReadOnly => false;

    public new ISwitchCase this[int index]
    {
        get => _switchCases[index];
        set => throw new NotImplementedException();
    }

    IReadOnlySwitchCase IReadOnlyList<IReadOnlySwitchCase>.this[int index]
        => _switchCases[index];

    public IEnumerator<ISwitchCase> GetEnumerator()
    {
        return _switchCases.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlySwitchCase> IEnumerable<IReadOnlySwitchCase>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void ChangeConditionExpression(IExpression expression)
    {
        throw new NotImplementedException();
    }

    public bool Contains(ISwitchCase item)
    {
        return _switchCases.Contains(item);
    }

    public int IndexOf(ISwitchCase item)
    {
        return _switchCases.IndexOf(item);
    }

    public void CopyTo(ISwitchCase[] array, int arrayIndex)
    {
        _switchCases.CopyTo(array, arrayIndex);
    }

    public void Add(ISwitchCase item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ISwitchCase item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ISwitchCase item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
