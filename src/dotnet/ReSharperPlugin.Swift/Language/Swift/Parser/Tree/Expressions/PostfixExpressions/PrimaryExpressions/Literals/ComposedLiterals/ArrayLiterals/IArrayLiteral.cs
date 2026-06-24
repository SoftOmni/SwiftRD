using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.ArrayLiterals;

public interface IArrayLiteral : IReadOnlyArrayLiteral, ILiteral<IExpression[]>, IList<IExpression>
{
    new IExpression[] GetValueCopy();
    
    new IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }
    
    new IExpression[] Value { get; }
    
    new int Count { get; }

    new IEnumerator<IExpression> GetEnumerator();
    
    new IExpression this[int index] { get; }
}
