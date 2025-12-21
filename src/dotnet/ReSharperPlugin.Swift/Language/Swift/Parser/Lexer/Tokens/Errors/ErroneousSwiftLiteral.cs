using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public abstract class ErroneousSwiftLiteral(string tokenId, int index)
    : ErroneousToken(tokenId, index);

public abstract class ErroneousTokenLiteralBacker<TType, TValue>(TType type, TValue valueOfContents, string value, string message, int index)
    : BackingErroneousToken(value, message, index) where TType : Type
{
    public TType Type { get; } = type;
    
    public TValue ValueOfContents { get; } = valueOfContents;
}