using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.SubscriptExpressions;

public class SubscriptExpression : SwiftCompositeNode, ISubscriptExpression
{
    public IPostfixExpression PostfixExpression { get; }

    public LeftSquareBracket LeftSquareBracket { get; }

    private readonly List<IFunctionCallArgument> _arguments;

    private readonly List<Comma> _commas;

    public RightSquareBracket RightSquareBracket { get; }

    internal SubscriptExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, LeftSquareBracket leftSquareBracket,
        List<IFunctionCallArgument> arguments, List<Comma> commas, RightSquareBracket rightSquareBracket)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        LeftSquareBracket = leftSquareBracket;
        _arguments = arguments;
        _commas = commas;
        RightSquareBracket = rightSquareBracket;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlySubscriptExpression.PostfixExpression => PostfixExpression;

    public IReadOnlyList<IFunctionCallArgument> FunctionCallArguments => _arguments;

    IReadOnlyList<IReadOnlyFunctionCallArgument> IReadOnlySubscriptExpression.FunctionCallArguments =>
        FunctionCallArguments;

    public IReadOnlyList<Comma> Commas => _commas;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public int Count => _arguments.Count;

    public bool IsReadOnly => false;

    public new IFunctionCallArgument this[int index]
    {
        get => _arguments[index];
        set => throw new System.NotImplementedException();
    }

    IReadOnlyFunctionCallArgument IReadOnlyList<IReadOnlyFunctionCallArgument>.this[int index] => _arguments[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IEnumerable<IReadOnlyFunctionCallArgument>.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IEnumerable<IFunctionCallArgument>.GetEnumerator()
    {
        return _arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> ISubscriptExpression.GetEnumerator()
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

    public void ChangePostfixExpression()
    {
        throw new System.NotImplementedException();
    }
}
