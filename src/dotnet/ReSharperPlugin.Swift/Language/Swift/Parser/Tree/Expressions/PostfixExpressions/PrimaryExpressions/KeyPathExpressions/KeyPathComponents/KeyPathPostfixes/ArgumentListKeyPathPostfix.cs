using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public class ArgumentListKeyPathPostfix : SwiftCompositeNode, IArgumentListKeyPathPostfix
{
    public LeftSquareBracket Start { get; }

    private readonly List<IFunctionCallArgument> _arguments;

    private readonly List<Comma> _commas;
    
    public RightSquareBracket End { get; }

    internal ArgumentListKeyPathPostfix(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftSquareBracket start, List<IFunctionCallArgument> arguments, List<Comma> commas, RightSquareBracket end)
        : base(buffer, children)
    {
        _arguments = arguments;
        _commas = commas;
        Start = start;
        End = end;
    }

    public IReadOnlyList<IFunctionCallArgument> Arguments => _arguments;

    IReadOnlyList<IReadOnlyFunctionCallArgument> IReadOnlyArgumentListKeyPathPostfix.Arguments => Arguments;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _arguments.Count;

    public bool IsReadOnly => false;

    public new IFunctionCallArgument this[int index]
    {
        get => _arguments[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyFunctionCallArgument IReadOnlyList<IReadOnlyFunctionCallArgument>.this[int index]
        => _arguments[index];

    IReadOnlyFunctionCallArgument IReadOnlyArgumentListKeyPathPostfix.this[int index] =>
        _arguments[index];

    public IEnumerator<IFunctionCallArgument> GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IEnumerable<IReadOnlyFunctionCallArgument>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IFunctionCallArgument item)
    {
        return _arguments.Contains(item);
    }

    public int IndexOf(IFunctionCallArgument item)
    {
        return _arguments.IndexOf(item);
    }

    public void CopyTo(IFunctionCallArgument[] array, int arrayIndex)
    {
        _arguments.CopyTo(array, arrayIndex);
    }

    public void Add(IFunctionCallArgument item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IFunctionCallArgument item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, IFunctionCallArgument item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
