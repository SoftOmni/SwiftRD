using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public abstract class ErroneousSwiftLiteral<TType, TValue>(string message, TType type, TValue valueOfContents, string value, int index)
    : ErroneousToken(value, message, index) where TType : Type
{
    public TType Type { get; } = type;
    
    public TValue ValueOfContents { get; } = valueOfContents;
}