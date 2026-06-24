using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class FunctionCallExpressionArgument : SwiftCompositeNode, IFunctionCallExpressionArgument
{
    public IIdentifier? Label { get; }

    public Colon? Colon { get; }

    public IExpression Expression { get; }

    internal FunctionCallExpressionArgument(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier? label, Colon? colon, IExpression expression)
        : base(buffer, children)
    {
        Label = label;
        Colon = colon;
        Expression = expression;
    }

    internal FunctionCallExpressionArgument(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IExpression expression)
        : base(buffer, children)
    {
        Expression = expression;
    }

    IReadOnlyIdentifier? IReadOnlyFunctionCallArgument.Label => Label;

    IReadOnlyExpression IReadOnlyFunctionCallExpressionArgument.Expression => Expression;

    public bool IsLabeled => Label is not null;

    public void ChangeLabel(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveLabel()
    {
        throw new NotImplementedException();
    }

    public void SetLabelTo(string label)
    {
        throw new NotImplementedException();
    }

    public void SetLabelTo(ReadOnlySpan<char> label)
    {
        throw new NotImplementedException();
    }

    public void SetLabelTo(IBuffer label)
    {
        throw new NotImplementedException();
    }

    public void SetLabelTo(IReadOnlyIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void SetLabelTo(IIdentifier identifier)
    {
        throw new NotImplementedException();
    }

    public void ChangeExpression(IExpression expression)
    {
        throw new NotImplementedException();
    }
}