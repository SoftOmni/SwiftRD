using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.PrefixOperators;

public class PrefixOperatorExpression : SwiftCompositeNode, IPrefixOperatorExpression
{
    public IPrefixOperator PrefixOperator { get; }

    public IPostfixExpression PostfixExpression { get; }

    public PrefixOperatorExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPrefixOperator @operator, IPostfixExpression postfixExpression)
        : base(buffer, children)
    {
        PrefixOperator = @operator;
        PostfixExpression = postfixExpression;

        ReturnType = SetDefaultReturnType();
    }

    public IType ReturnType { get; internal set; }
    
    IReadOnlyPrefixOperator IReadOnlyPrefixOperatorExpression.PrefixOperator => PrefixOperator;

    IPostfixExpression IPrefixOperatorExpression.PostfixExpression => PostfixExpression;

    IReadOnlyPostfixExpression IReadOnlyPrefixOperatorExpression.PostfixExpression => PostfixExpression;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeOperator(IPrefixOperator newOperator)
    {
        throw new NotImplementedException();
    }

    public void ChangePostfixExpression(IPostfixExpression newExpression)
    {
        throw new NotImplementedException();
    }

    private static IType SetDefaultReturnType()
    {
        throw new NotImplementedException();
    }
}
