using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;

public interface IReadOnlyFileLiteral : IReadOnlyPlaygroundLiteral<IReadOnlyExpression>
{
    ReservedFileLiteralKeyword FileLiteralKeyword { get; }
    
    LeftParenthesis LeftArgumentParenthesis { get; }
    
    IReadOnlyIdentifier RessourceNameArgumentLabel { get; }
    
    Colon RessourceNameArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression RessourceNameArgumentValue { get; }
    
    RightParenthesis RightArgumentParenthesis { get; }
}
