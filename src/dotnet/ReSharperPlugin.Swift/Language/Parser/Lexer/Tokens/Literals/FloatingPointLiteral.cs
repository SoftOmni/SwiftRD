using ReSharperPlugin.Swift.Language.Semantics.Type;
using ExtendedNumerics;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class FloatingPointLiteral<TType>(TType type, BigDecimal valueOfContents, string value, FloatingPointRepresentation representation = FloatingPointRepresentation.Decimal)
    : SwiftLiteral<TType, BigDecimal>(type, valueOfContents, value, SwiftTokens.FloatingPointLiteralIndex) where TType : Type
{
    public override bool IsConstantLiteral => true;
    
    public override string TokenRepresentation { get; } = value;
    
    public FloatingPointRepresentation Representation { get; } = representation;
}

public enum FloatingPointRepresentation
{
    Decimal,
    Hexadecimal
}