using SoftOmni.SwiftRd.Language.Semantics.Type;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public abstract class SwiftLiteral(string tokenId, int index)
    : SwiftTokenNodeType(tokenId, index);

public abstract class TokenLiteralBacker<TType, TValue>(TType type, TValue valueOfContents, string value, int index)
    : BackerToken(value, index) where TType : Type
{
    public TType Type { get; } = type;
    
    public TValue ValueOfContents { get; } = valueOfContents;
}