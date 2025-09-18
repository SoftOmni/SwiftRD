using System.Numerics;
using ReSharperPlugin.Swift.Language.Semantics.Type;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousIntegerLiteralToken() : ErroneousSwiftLiteral(SwiftTokens.ErroneousIntegerLiteralId, SwiftTokens.ErroneousIntegerLiteralIndex);

public class BackingErroneousIntegerLiteralToken<TType>(
    TType type,
    BigInteger valueOfContents,
    string value,
    BackingErroneousIntegerLiteralToken<Type>.ErrorCase errorCase) : ErroneousTokenLiteralBacker<TType, BigInteger>(type, valueOfContents,
    value, errorCase.ToMessage(), SwiftTokens.ErroneousIntegerLiteralIndex) where TType : Type
{
    public enum ErrorCase
    { }
}

public static class ErroneousIntegerLiteralTokenExtensions
{
    public static string ToMessage<TType>(this BackingErroneousIntegerLiteralToken<TType>.ErrorCase token) where TType : Type
    {
        return token switch
        {
            _ => string.Empty
        };
    }
}