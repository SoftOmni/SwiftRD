
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public interface ITupleExpressionElement : IReadOnlyTupleExpressionElement
{
    new IIdentifier Identifier { get; }
    
    new IExpression Expression { get; }

    void SetIdentifier(IIdentifier identifier);

    void SetExpression(IExpression expression);
}

