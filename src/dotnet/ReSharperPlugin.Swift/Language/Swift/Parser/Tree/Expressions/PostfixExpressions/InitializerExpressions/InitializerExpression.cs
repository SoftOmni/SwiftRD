using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.InitializerExpressions;

public class InitializerExpression : SwiftCompositeNode, IInitializerExpression
{
    public IPostfixExpression PostfixExpression { get; }

    public Period Period { get; }

    public Init Init { get; }

    public LeftParenthesis? LeftParenthesis { get; }

    public IArgumentNames? ArgumentNames { get; }

    public RightParenthesis? RightParenthesis { get; }

    internal InitializerExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period, Init init)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        Init = init;

        ReturnType = UnknownType.Instance;
    }
    
    internal InitializerExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period, Init init,
        LeftParenthesis leftParenthesis, IArgumentNames argumentNames, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        Init = init;
        
        LeftParenthesis = leftParenthesis;
        ArgumentNames = argumentNames;
        RightParenthesis = rightParenthesis;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyInitializerExpression.PostfixExpression => PostfixExpression;

    IReadOnlyArgumentNames? IReadOnlyInitializerExpression.ArgumentNames => ArgumentNames;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveArgumentNames()
    {
        throw new System.NotImplementedException();
    }

    public void SetArgumentNamesTo(IArgumentNames? newArgumentNames)
    {
        throw new System.NotImplementedException();
    }
}
