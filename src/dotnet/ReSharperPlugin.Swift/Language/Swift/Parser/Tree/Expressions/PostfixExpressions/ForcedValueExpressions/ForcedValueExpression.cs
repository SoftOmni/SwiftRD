using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ForcedValueExpressions;

public class ForcedValueExpression : SwiftCompositeNode, IForcedValueExpression
{
    public IPostfixExpression PostfixExpression { get; }
    
    public ExclamationMark ExclamationMark { get; }

    internal ForcedValueExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        ExclamationMark = exclamationMark;
        
        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyForcedValueExpression.PostfixExpression => PostfixExpression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new System.NotImplementedException();
    }
}
