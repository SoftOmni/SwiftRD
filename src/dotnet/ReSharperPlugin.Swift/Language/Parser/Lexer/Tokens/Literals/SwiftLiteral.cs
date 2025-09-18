using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public abstract class SwiftLiteral(string tokenId, int index)
    : SwiftTokenNodeType(tokenId, index);

public abstract class TokenLiteralBacker<TType, TValue>(TType type, TValue valueOfContents, string value, int index)
    : BackerToken(value, index) where TType : Type
{
    public TType Type { get; } = type;
    
    public TValue ValueOfContents { get; } = valueOfContents;
}