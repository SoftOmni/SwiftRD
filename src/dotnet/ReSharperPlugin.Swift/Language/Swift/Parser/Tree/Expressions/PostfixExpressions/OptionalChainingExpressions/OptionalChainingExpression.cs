using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.OptionalChainingExpressions;

public class OptionalChainingExpression : SwiftCompositeNode, IOptionalChainingExpression
{
    public IPostfixExpression PostfixExpression { get; }

    public QuestionMark QuestionMark { get; }

    internal OptionalChainingExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, QuestionMark questionMark)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        QuestionMark = questionMark;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyOptionalChainingExpression.PostfixExpression => PostfixExpression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new NotImplementedException();
    }
}

