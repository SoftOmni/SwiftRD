using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

public class InfixExpressionGroup : SwiftCompositeNode, IInfixExpressionGroup
{
    private readonly List<IInfixExpression> _expressions;

    public InfixExpressionGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        List<IInfixExpression> expressions)
        : base(buffer, children)
    {
        _expressions = expressions;
    }

    public int Count => _expressions.Count;

    public bool IsReadOnly => false;

    public IReadOnlyList<IReadOnlyInfixExpression> InfixExpressions => _expressions;

    public new IInfixExpression this[int index]
    {
        get => _expressions[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyInfixExpression IReadOnlyInfixExpressionGroup.this[int index] => _expressions[index];

    IReadOnlyInfixExpression IReadOnlyList<IReadOnlyInfixExpression>.this[int index] => _expressions[index];

    public IEnumerator GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IInfixExpression> IInfixExpressionGroup.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IInfixExpression> IEnumerable<IInfixExpression>.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IReadOnlyInfixExpression> IEnumerable<IReadOnlyInfixExpression>.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    IEnumerator<IReadOnlyInfixExpression> IReadOnlyInfixExpressionGroup.GetEnumerator()
    {
        return _expressions.GetEnumerator();
    }

    public bool Contains(IInfixExpression item)
    {
        return _expressions.Contains(item);
    }

    public void CopyTo(IInfixExpression[] array, int arrayIndex)
    {
        _expressions.CopyTo(array, arrayIndex);
    }

    public int IndexOf(IInfixExpression item)
    {
        return _expressions.IndexOf(item);
    }

    public void Add(IInfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IInfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IInfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
