using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public interface IDictionaryLiteral : IReadOnlyDictionaryLiteral, ILiteral<IDictionary<IExpression, IExpression>>, IList<IDictionaryLiteralElement>
{
    new int Count { get; }

    new IEnumerator<IDictionaryLiteralElement> GetEnumerator();
    
    new IDictionaryLiteralElement this[int index] { get; }
    
    new IDictionary<IExpression, IExpression> Value { get; }

    new IDictionary<IExpression, IExpression> GetValueCopy();
    
    new IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }
}
