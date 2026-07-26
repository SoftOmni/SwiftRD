using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public class TrailingClosuresGroup : SwiftCompositeNode, ITrailingClosuresGroup
{
    public IClosureExpression FirstClosure { get; }

    private readonly List<ILabeledTrailingExpression> _labeledTrailingExpressions;

    internal TrailingClosuresGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IClosureExpression firstClosure, List<ILabeledTrailingExpression> labeledTrailingExpressions)
        : base(buffer, children)
    {
        FirstClosure = firstClosure;
        _labeledTrailingExpressions = labeledTrailingExpressions;
    }

    IReadOnlyClosureExpression IReadOnlyTrailingClosuresGroup.FirstClosure => FirstClosure;

    public IReadOnlyList<IReadOnlyLabeledTrailingExpression> TrailingLabeledClosureExpressions =>
        _labeledTrailingExpressions;
    
    public int Count => _labeledTrailingExpressions.Count;

    public bool IsReadOnly => false;

    public new ILabeledTrailingExpression this[int index]
    {
        get => _labeledTrailingExpressions[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyLabeledTrailingExpression IReadOnlyList<IReadOnlyLabeledTrailingExpression>.this[int index] 
        => _labeledTrailingExpressions[index];

    IReadOnlyLabeledTrailingExpression IReadOnlyTrailingClosuresGroup.this[int index] => _labeledTrailingExpressions[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _labeledTrailingExpressions.GetEnumerator();
    }

    IEnumerator<IReadOnlyLabeledTrailingExpression> IEnumerable<IReadOnlyLabeledTrailingExpression>.GetEnumerator()
    {
        return _labeledTrailingExpressions.GetEnumerator();
    }

    IEnumerator<IReadOnlyLabeledTrailingExpression> IReadOnlyTrailingClosuresGroup.GetEnumerator()
    {
        return _labeledTrailingExpressions.GetEnumerator();
    }

    IEnumerator<ILabeledTrailingExpression> IEnumerable<ILabeledTrailingExpression>.GetEnumerator()
    {
        return _labeledTrailingExpressions.GetEnumerator();
    }

    IEnumerator<ILabeledTrailingExpression> ITrailingClosuresGroup.GetEnumerator()
    {
        return _labeledTrailingExpressions.GetEnumerator();
    }

    public bool Contains(ILabeledTrailingExpression item)
    {
        return _labeledTrailingExpressions.Contains(item);
    }

    public int IndexOf(ILabeledTrailingExpression item)
    {
        return _labeledTrailingExpressions.IndexOf(item);
    }

    public void CopyTo(ILabeledTrailingExpression[] array, int arrayIndex)
    {
        _labeledTrailingExpressions.CopyTo(array, arrayIndex);
    }

    public void Add(ILabeledTrailingExpression item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(ILabeledTrailingExpression item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, ILabeledTrailingExpression item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}