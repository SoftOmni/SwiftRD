using ExtendedNumerics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public interface IFloatingPointLiteral : ILiteral<BigDecimal>, IReadOnlyFloatingPointLiteral,
    IRawValueStyleEnumCaseApprovedLiteral
{
    void ChangeFormatting(IFloatingPointLiteralFormatting formatting);
}
