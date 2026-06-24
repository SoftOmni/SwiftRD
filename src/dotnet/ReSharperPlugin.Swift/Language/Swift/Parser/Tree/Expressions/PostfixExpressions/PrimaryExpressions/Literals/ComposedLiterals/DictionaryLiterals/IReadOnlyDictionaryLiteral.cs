using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public interface IReadOnlyDictionaryLiteral : IReadOnlyLiteral<IDictionary<IReadOnlyExpression, IReadOnlyExpression>>, IReadOnlyList<IReadOnlyDictionaryLiteralElement>
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyDictionaryLiteralElement> DictionaryLiteralElements { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}
