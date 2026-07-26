using System.Numerics;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public interface IIntegerLiteral : ILiteral<BigInteger>, IReadOnlyIntegerLiteral,
    IRawValueStyleEnumCaseApprovedLiteral
{
    void MakeBinary(IIntegerLiteralFormatting formatting);

    void MakeOctal(IIntegerLiteralFormatting formatting);

    void MakeDecimal(IIntegerLiteralFormatting formatting);

    void MakeHexadecimal(IIntegerLiteralFormatting formatting);

    void ChangeFormatting(IIntegerLiteralFormatting formatting);

    void MakeUppercaseIfInHex();

    void MakeLowercaseIfInHex();
}
