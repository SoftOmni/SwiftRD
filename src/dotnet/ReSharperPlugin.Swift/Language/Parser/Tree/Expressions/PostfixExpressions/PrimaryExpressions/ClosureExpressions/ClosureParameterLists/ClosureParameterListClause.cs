using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public class ClosureParameterListClause : ClosureParameterClause, IList<ClosureParameter>
{
    public LeftParenthesis? LeftParenthesis { get; internal set; }

    private List<ClosureParameter> _closureParameters = [];

    private List<Comma> Commas = [];
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public ClosureParameterListClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureParameterListClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureParameterListClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ClosureParameterListClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<ClosureParameter> ClosureParameters => _closureParameters;
    
    public IEnumerator<ClosureParameter> GetEnumerator()
    {
        throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(ClosureParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Contains(ClosureParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void CopyTo(ClosureParameter[] array, int arrayIndex)
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(ClosureParameter item)
    {
        throw new System.NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }
    public int IndexOf(ClosureParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, ClosureParameter item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }

    public ClosureParameter this[int index]
    {
        get => throw new System.NotImplementedException();
        set => throw new System.NotImplementedException();
    }
}