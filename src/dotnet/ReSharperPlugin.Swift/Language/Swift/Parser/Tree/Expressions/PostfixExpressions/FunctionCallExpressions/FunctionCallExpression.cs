using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;

public class FunctionCallExpression : SwiftCompositeNode, IFunctionCallExpression
{
    public IPostfixExpression PostfixExpression { get; }

    public IFunctionCallArgumentList? Arguments { get; }

    public ITrailingClosuresGroup? TrailingClosuresGroup { get; }

    internal FunctionCallExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, IFunctionCallArgumentList? arguments = null,
        ITrailingClosuresGroup? trailingClosuresGroup = null)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Arguments = arguments;
        TrailingClosuresGroup = trailingClosuresGroup;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyFunctionCallExpression.PostfixExpression => PostfixExpression;

    IReadOnlyFunctionCallArgumentList? IReadOnlyFunctionCallExpression.Arguments => Arguments;

    IReadOnlyTrailingClosuresGroup? IReadOnlyFunctionCallExpression.TrailingClosuresGroup => TrailingClosuresGroup;

    public int Count => Arguments?.Count ?? 0;

    public bool IsReadOnly => false;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public IReadOnlyList<IReadOnlyFunctionCallArgument> ArgumentsList =>
        Arguments is null ? new List<IReadOnlyFunctionCallArgument>() : Arguments.Arguments;

    public new IFunctionCallArgument this[int index]
    {
        get => Arguments is null ? throw new ArgumentOutOfRangeException(nameof(index)) : Arguments[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyFunctionCallArgument IReadOnlyList<IReadOnlyFunctionCallArgument>.this[int index] =>
        Arguments is null ? throw new ArgumentOutOfRangeException(nameof(index)) : Arguments[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Arguments is null ? new EmptyEnumerator() : Arguments.GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IEnumerable<IReadOnlyFunctionCallArgument>.GetEnumerator()
    {
        return Arguments is null ? new EmptyEnumerator() : Arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IEnumerable<IFunctionCallArgument>.GetEnumerator()
    {
        return Arguments is null ? new EmptyEnumerator() : Arguments.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IFunctionCallExpression.GetEnumerator()
    {
        return Arguments is null ? new EmptyEnumerator() : Arguments.GetEnumerator();
    }

    public bool Contains(IFunctionCallArgument item)
    {
        return Arguments?.Contains(item) ?? false;
    }

    public int IndexOf(IFunctionCallArgument item)
    {
        return Arguments?.IndexOf(item) ?? -1;
    }

    public void CopyTo(IFunctionCallArgument[] array, int arrayIndex)
    {
        if (Arguments is null) throw new ArgumentNullException(nameof(arrayIndex));
        Arguments.CopyTo(array, arrayIndex);
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

    private struct EmptyEnumerator : IEnumerator<IFunctionCallArgument>
    {
        public void Dispose()
        {
            // nothing to do
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            // Nothing to do
        }

        public IFunctionCallArgument Current => null!;

        object? IEnumerator.Current => Current;
    }
}