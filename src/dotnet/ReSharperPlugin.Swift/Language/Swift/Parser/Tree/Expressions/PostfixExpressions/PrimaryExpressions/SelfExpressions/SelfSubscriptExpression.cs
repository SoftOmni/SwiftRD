using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public class SelfSubscriptExpression : SwiftCompositeNode, ISelfSubscriptExpression
{
    public SelfLowercase SelfLowercase { get; }

    public LeftSquareBracket LeftSquareBracket { get; }
    
    public IFunctionCallArgumentList ArgumentList { get; }

    public RightSquareBracket RightSquareBracket { get; }

    internal SelfSubscriptExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        SelfLowercase selfLowercase, LeftSquareBracket leftSquareBracket,
        IFunctionCallArgumentList argumentList, RightSquareBracket rightSquareBracket)
        : base(buffer, children)
    {
        SelfLowercase = selfLowercase;
        LeftSquareBracket = leftSquareBracket;
        ArgumentList = argumentList;
        RightSquareBracket = rightSquareBracket;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyFunctionCallArgumentList IReadOnlySelfSubscriptExpression.ArgumentList => ArgumentList;

    public IReadOnlyList<IFunctionCallArgument> Arguments => ArgumentList.Arguments;

    IReadOnlyList<IReadOnlyFunctionCallArgument> IReadOnlySelfSubscriptExpression.Arguments => ArgumentList;

    public IReadOnlyList<Comma> Commas => ArgumentList.Commas;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public int Count => ArgumentList.Count;

    public bool IsReadOnly => false;

    public new IFunctionCallArgument this[int index]
    {
        get => ArgumentList[index];
        set => throw new NotImplementedException();
    }

    IReadOnlyFunctionCallArgument IReadOnlyList<IReadOnlyFunctionCallArgument>.this[int index]
        => ArgumentList[index];

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ArgumentList.GetEnumerator();
    }

    IEnumerator<IReadOnlyFunctionCallArgument> IEnumerable<IReadOnlyFunctionCallArgument>.GetEnumerator()
    {
        return ArgumentList.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> IEnumerable<IFunctionCallArgument>.GetEnumerator()
    {
        return ArgumentList.GetEnumerator();
    }

    IEnumerator<IFunctionCallArgument> ISelfSubscriptExpression.GetEnumerator()
    {
        return ArgumentList.GetEnumerator();
    }

    public bool Contains(IFunctionCallArgument item)
    {
        return ArgumentList.Contains(item);
    }

    public int IndexOf(IFunctionCallArgument item)
    {
        return ArgumentList.IndexOf(item);
    }

    public void CopyTo(IFunctionCallArgument[] array, int arrayIndex)
    {
        ArgumentList.CopyTo(array, arrayIndex);
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
