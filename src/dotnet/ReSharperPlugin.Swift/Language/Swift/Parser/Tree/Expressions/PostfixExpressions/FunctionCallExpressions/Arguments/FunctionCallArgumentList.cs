using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class FunctionCallArgumentList : SwiftCompositeNode, IFunctionCallArgumentList
{
    public LeftParenthesis LeftParenthesis { get; }

    private readonly List<IFunctionCallArgument> _arguments;

    private readonly List<Comma> _commas;
    
    public RightParenthesis RightParenthesis { get; }

    internal FunctionCallArgumentList(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        LeftParenthesis leftParenthesis, List<IFunctionCallArgument> arguments,
        List<Comma> commas, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        LeftParenthesis = leftParenthesis;
        _arguments = arguments;
        _commas = commas;
        RightParenthesis = rightParenthesis;
    }

    public IReadOnlyList<IFunctionCallArgument> Arguments => _arguments;

    IReadOnlyList<IReadOnlyFunctionCallArgument> IReadOnlyFunctionCallArgumentList.Arguments => Arguments;

    public IReadOnlyList<Comma> Commas => _commas;

    public int Count => _arguments.Count;

    public bool IsReadOnly => false;

    public new IFunctionCallArgument this[int index]
    {
        get => _arguments[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyFunctionCallArgument IReadOnlyFunctionCallArgumentList.this[int index] => _arguments[index];

    IReadOnlyFunctionCallArgument IReadOnlyList<IReadOnlyFunctionCallArgument>.this[int index] => _arguments[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IEnumerable<IReadOnlyFunctionCallArgument>.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IReadOnlyFunctionCallArgumentList.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IEnumerable<IFunctionCallArgument>.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IFunctionCallArgumentList.GetEnumerator()
    {
        return _arguments.GetEnumerator();
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
        throw new System.NotImplementedException();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public bool Remove(IFunctionCallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void Insert(int index, IFunctionCallArgument item)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotImplementedException();
    }
}
