using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Images;

public interface IReadOnlyImageLiteral : IReadOnlyPlaygroundLiteral<IReadOnlyExpression>
{
    ReservedImageLiteralKeyword ImageLiteralKeyword { get; }
    
    LeftParenthesis LeftArgumentParenthesis { get; }
    
    IReadOnlyIdentifier RessourceNameArgumentLabel { get; }
    
    Colon RessourceNameArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression RessourceNameArgumentValue { get; }
    
    RightParenthesis RightArgumentParenthesis { get; }
}
