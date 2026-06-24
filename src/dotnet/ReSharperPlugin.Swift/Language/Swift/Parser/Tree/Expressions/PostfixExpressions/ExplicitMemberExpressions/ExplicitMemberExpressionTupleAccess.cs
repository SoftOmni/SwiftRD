using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class ExplicitMemberExpressionTupleAccess : SwiftCompositeNode, IExplicitMemberExpressionTupleAccess
{
    public IPostfixExpression PostfixExpression { get; }
    
    public Period Period { get; }
    
    public IIntegerLiteral FieldNumber { get; }

    internal ExplicitMemberExpressionTupleAccess(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IPostfixExpression postfixExpression, Period period, IIntegerLiteral fieldNumber)
        : base(buffer, children)
    {
        PostfixExpression = postfixExpression;
        Period = period;
        FieldNumber = fieldNumber;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyPostfixExpression IReadOnlyExplicitMemberExpression.PostfixExpression => PostfixExpression;

    IReadOnlyIntegerLiteral IReadOnlyExplicitMemberExpressionTupleAccess.FieldNumber => FieldNumber;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangePostfixExpression(IPostfixExpression newPostfixExpression)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeFieldNumber(IIntegerLiteral fieldNumber)
    {
        throw new System.NotImplementedException();
    }
}
