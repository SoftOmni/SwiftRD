using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public abstract class ErroneousSwiftLiteral<TType, TValue>(
    string name,
    string message,
    TType type,
    TValue valueOfContents,
    string value,
    int index)
    : ErroneousToken(name, value, message, index) where TType : Type
{
    public TType Type { get; } = type;

    public TValue ValueOfContents { get; } = valueOfContents;
}