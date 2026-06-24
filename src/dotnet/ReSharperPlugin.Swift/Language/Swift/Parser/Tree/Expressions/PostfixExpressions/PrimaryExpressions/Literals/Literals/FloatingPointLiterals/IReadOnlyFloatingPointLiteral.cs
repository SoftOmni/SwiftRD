using System.Numerics;
using ExtendedNumerics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public interface IReadOnlyFloatingPointLiteral : IReadOnlyLiteral<BigDecimal>
{
    enum Base
    {
        Decimal,
        Hexadecimal
    }

    enum Sign
    {
        Positive,
        Negative
    }
    
    IFloatingPointLiteralFormatting Formatting { get; }
    
    IReadOnlyIntegerLiteral IntegralPartDetachedValue { get; }

    BigInteger IntegralPartValue { get; }
    
    int DecimalSeparatorIndex { get; }
    
    bool HasDecimalPart { get; }
    
    IReadOnlyIntegerLiteral? DecimalPartDetachedValue { get; }
    
    BigInteger DecimalPartValue { get; }
    
    int ExponentIndex { get; }
    
    bool HasExponentPart { get; }
    
    Sign ExponentSign { get; }
    
    bool HasExplicitExponentSign { get; }
    
    IReadOnlyIntegerLiteral ExponentValueDetachedValue { get; }
    
    BigInteger ExponentValue { get; }
    
    int IndexOfNonPresence { get; }
}