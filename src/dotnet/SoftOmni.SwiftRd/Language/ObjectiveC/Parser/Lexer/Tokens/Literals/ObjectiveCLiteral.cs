using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Literals;

public abstract class ObjectiveCLiteral(string tokenId, int index)
    : ObjectiveCTokenNodeType(tokenId, index);

public abstract class TokenLiteralBacker<TValue>(TValue valueOfContents, string value, int index)
    : BackerToken(value, index)
{
    public TValue ValueOfContents { get; internal set; } = valueOfContents;
}
