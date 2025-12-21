using System.Numerics;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class IntegerLiteralToken()
    : SwiftLiteral(SwiftTokens.IntegerLiteralId, SwiftTokens.IntegerLiteralIndex)
{
    public override bool IsConstantLiteral => true;

    public override string TokenRepresentation => SwiftTokens.IntegerLiteralId;
}

public class IntegerBackingLiteralToken<TType>(TType type, BigInteger valueOfContents, string value, IntegerRepresentation representation = IntegerRepresentation.Decimal)
    : TokenLiteralBacker<TType, BigInteger>(type, valueOfContents, value, SwiftTokens.FalseIndex) where TType : Type
{
    public IntegerRepresentation Representation { get; } = representation;
}

public enum IntegerRepresentation
{
    Decimal,
    Hexadecimal,
    Binary
}