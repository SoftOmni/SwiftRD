using System.Numerics;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public interface IIntegerLiteral : ILiteral<Int, BigInteger>, IReadOnlyIntegerLiteral
{
    void MakeBinary(IIntegerLiteralFormatting formatting);

    void MakeOctal(IIntegerLiteralFormatting formatting);

    void MakeDecimal(IIntegerLiteralFormatting formatting);

    void MakeHexadecimal(IIntegerLiteralFormatting formatting);

    void ChangeFormatting(IIntegerLiteralFormatting formatting);

    void MakeUppercaseIfInHex();

    void MakeLowercaseIfInHex();
}
