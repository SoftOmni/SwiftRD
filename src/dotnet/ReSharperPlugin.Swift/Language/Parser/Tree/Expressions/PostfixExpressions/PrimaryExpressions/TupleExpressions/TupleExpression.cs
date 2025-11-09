using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public class TupleExpression : PrimaryExpressionInternalNode, IList<TupleElement>
{
    public LeftParenthesis? LeftParenthesis { get; internal set; }

    private List<TupleElement> _tupleElements = [];

    private List<Comma> _commas = [];
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public TupleExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TupleExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TupleExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public TupleExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<TupleElement> TupleElements => _tupleElements;
    
    public IEnumerator<TupleElement> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(TupleElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(TupleElement item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(TupleElement[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(TupleElement item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(TupleElement item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, TupleElement item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public TupleElement this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}