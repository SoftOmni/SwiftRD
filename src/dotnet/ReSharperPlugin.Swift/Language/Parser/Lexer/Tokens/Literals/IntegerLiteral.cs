using System.Numerics;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class IntegerLiteralToken<TType>(TType type, BigInteger valueOfContents, string value, IntegerRepresentation representation = IntegerRepresentation.Decimal)
    : SwiftLiteral<TType, BigInteger>(type, valueOfContents, value, SwiftTokens.IntegerLiteralIndex) where TType : Type
{
    public override bool IsConstantLiteral => true;
    
    public override string TokenRepresentation { get; } = value;
    
    public IntegerRepresentation Representation { get; } = representation;
}

public enum IntegerRepresentation
{
    Decimal,
    Hexadecimal,
    Binary
}