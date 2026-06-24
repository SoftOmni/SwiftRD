using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class FunctionCallOperatorArgument : SwiftCompositeNode, IFunctionCallOperatorArgument
{
    public IIdentifier? Label { get; }
    
    public Colon? Colon { get; }

    public IOperator Operator { get; }

    internal FunctionCallOperatorArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier label, Colon colon, IOperator @operator)
        : base(buffer, children)
    {
        Label = label;
        Colon = colon;
        Operator = @operator;
    }

    internal FunctionCallOperatorArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IOperator @operator)
        : base(buffer, children)
    {
        Operator = @operator;
    }

    IReadOnlyIdentifier? IReadOnlyFunctionCallArgument.Label => Label;

    IReadOnlyOperator IReadOnlyFunctionCallOperatorArgument.Operator => Operator;

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

    public void ChangeOperator(IOperator newOperator)
    {
        throw new NotImplementedException();
    }
}
