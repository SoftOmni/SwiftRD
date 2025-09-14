using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public abstract class SwiftLiteral<TType, TValue>(TType type, TValue valueOfContents, string value, int index)
    : SwiftTokenNodeType(value, index) where TType : Type
{
    public TType Type { get; } = type;
    
    public TValue ValueOfContents { get; } = valueOfContents;
}