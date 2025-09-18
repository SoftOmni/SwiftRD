using ReSharperPlugin.Swift.Language.Semantics.Type;
using ExtendedNumerics;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class FloatingPointLiteral()
    : SwiftLiteral(SwiftTokens.FloatingPointLiteralId, SwiftTokens.FloatingPointLiteralIndex)
{
    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation { get; } = SwiftTokens.FloatingPointLiteralId;
}

public class FloatingPointLiteralTokenBaker<TType>(
    TType type,
    BigDecimal valueOfContents,
    string value,
    FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal) :
    TokenLiteralBacker<TType, BigDecimal>(type, valueOfContents, value, SwiftTokens.FloatingPointLiteralIndex) where TType : Type
{
    public FloatingPointRepresentation Representation { get; } = representation;
}

public enum FloatingPointRepresentation
{
    Decimal,
    Hexadecimal
}