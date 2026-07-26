using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class ExplicitMemberExpressionFunctionMember
    : SwiftCompositeNode, IExplicitMemberExpressionFunctionMember
{
    public IPostfixExpression PostfixExpression { get; }

    public Period Period { get; }

    public IIdentifier FunctionName { get; }

    public LeftParenthesis LeftParenthesis { get; }

    public IArgumentNames ArgumentNames { get; }

    public RightParenthesis RightParenthesis { get; }

    internal ExplicitMemberExpressionFunctionMember(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period,
        IIdentifier functionName,
        LeftParenthesis leftParenthesis,
        IArgumentNames argumentNames,
        RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        FunctionName = functionName;
        LeftParenthesis = leftParenthesis;
        ArgumentNames = argumentNames;
        RightParenthesis = rightParenthesis;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyExplicitMemberExpression.PostfixExpression => PostfixExpression;

    IReadOnlyIdentifier IReadOnlyExplicitMemberExpressionFunctionMember.FunctionName => FunctionName;

    IReadOnlyArgumentNames IReadOnlyExplicitMemberExpressionFunctionMember.ArgumentNames => ArgumentNames;

    public IType ReturnType { get; }
    
    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new NotImplementedException();
    }

    public void ChangeFunctionName(IIdentifier newFunctionName)
    {
        throw new NotImplementedException();
    }

    public void ChangeArguments(IArgumentNames newArguments)
    {
        throw new NotImplementedException();
    }
}
