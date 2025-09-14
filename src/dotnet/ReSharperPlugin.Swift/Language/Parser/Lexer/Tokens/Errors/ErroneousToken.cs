using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;

public class ErroneousToken(string value, string message, int errorIndex) : SwiftTokenNodeType(value, errorIndex)
{
    public override string TokenRepresentation { get; } = value;
    
    public virtual string ErrorMessage { get; } = message;
}