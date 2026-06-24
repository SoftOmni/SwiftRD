using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PostfixSelfExpressions;

public class PostfixSelfExpression : SwiftCompositeNode, IPostfixSelfExpression
{
    public IPostfixExpression PostfixExpression { get; }

    public Period Period { get; }

    public SelfLowercase SelfLowercase { get; }

    internal PostfixSelfExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period, SelfLowercase selfLowercase)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        SelfLowercase = selfLowercase;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyPostfixSelfExpression.PostfixExpression => PostfixExpression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new System.NotImplementedException();
    }
}
