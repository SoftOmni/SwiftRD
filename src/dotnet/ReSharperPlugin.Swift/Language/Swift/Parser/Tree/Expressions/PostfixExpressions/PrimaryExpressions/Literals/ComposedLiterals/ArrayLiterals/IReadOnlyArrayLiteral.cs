using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.ArrayLiterals;

public interface IReadOnlyArrayLiteral : IReadOnlyLiteral<IReadOnlyExpression[]>, IReadOnlyList<IReadOnlyExpression>
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyExpression> Expressions { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}