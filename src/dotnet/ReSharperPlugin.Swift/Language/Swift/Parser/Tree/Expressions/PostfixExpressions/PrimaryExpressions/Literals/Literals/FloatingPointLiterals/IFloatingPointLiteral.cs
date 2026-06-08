using ExtendedNumerics;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public interface IFloatingPointLiteral : ILiteral<Double, BigDecimal>, IReadOnlyFloatingPointLiteral
{
    void ChangeFormatting(IFloatingPointLiteralFormatting formatting);
}