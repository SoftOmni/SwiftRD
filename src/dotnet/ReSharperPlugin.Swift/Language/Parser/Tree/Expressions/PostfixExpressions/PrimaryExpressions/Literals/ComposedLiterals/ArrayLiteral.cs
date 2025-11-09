using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals;

public class ArrayLiteral : LiteralExpressionInternalNode, IList<Expression>, ILiteral<Array, System.Array>
{
    public LeftSquareBracket? LeftCurlyBrace { get; internal set; }

    private List<Expression> _expressions = [];
    
    public RightSquareBracket? RightCurlyBrace { get; internal set; }
    
    public ArrayLiteral(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ArrayLiteral(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ArrayLiteral(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ArrayLiteral(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<Expression> Expressions => _expressions;
    public IEnumerator<Expression> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Expression item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(Expression item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(Expression[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(Expression item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(Expression item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, Expression item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public Expression this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }

    public Array Type { get; }
    public System.Array Value { get; }
    public System.Array GetValueCopy()
    {
        throw new System.NotImplementedException();
    }

    public void SetValue(System.Array newValue)
    {
        throw new System.NotImplementedException();
    }
}