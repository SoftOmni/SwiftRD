using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.ClojureParameterLists;

public class ClosureParameterClause : SwiftCompositeNode, IClosureParameterClause
{
    public LeftParenthesis LeftParenthesis { get; }

    private readonly List<IClosureParameter> _parameters;

    private readonly List<Comma> _commas;

    public RightParenthesis RightParenthesis { get; }

    internal ClosureParameterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis, List<IClosureParameter> parameters, List<Comma> commas,
        RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        _parameters = parameters;
        _commas = commas;
        LeftParenthesis = leftParenthesis;
        RightParenthesis = rightParenthesis;
    }

    public IReadOnlyList<IReadOnlyClosureParameter> Parameters => _parameters;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _parameters.Count;

    public bool IsReadOnly => false;

    public new IClosureParameter this[int index]
    {
        get => _parameters[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyClosureParameter IReadOnlyList<IReadOnlyClosureParameter>.this[int index]
        => _parameters[index];

    public IEnumerator<IClosureParameter> GetEnumerator()
    {
        return _parameters.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyClosureParameter> IEnumerable<IReadOnlyClosureParameter>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IClosureParameter item)
    {
        return _parameters.Contains(item);
    }

    public int IndexOf(IClosureParameter item)
    {
        return _parameters.IndexOf(item);
    }

    public void CopyTo(IClosureParameter[] array, int arrayIndex)
    {
        _parameters.CopyTo(array, arrayIndex);
    }

    public void Add(IClosureParameter item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IClosureParameter item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IClosureParameter item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}