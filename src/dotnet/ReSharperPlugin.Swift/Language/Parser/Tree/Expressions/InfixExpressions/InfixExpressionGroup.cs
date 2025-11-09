using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.InfixExpressions;

public class InfixExpressionGroup : SwiftInternalNode, IList<InfixExpression>
{
    private List<InfixExpression> _infixExpressions = [];

    public InfixExpressionGroup(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixExpressionGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixExpressionGroup(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public InfixExpressionGroup(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<InfixExpression> InfixExpressions => _infixExpressions;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<InfixExpression> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    public void Add(InfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(InfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(InfixExpression[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(InfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(InfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, InfixExpression item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public InfixExpression this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}