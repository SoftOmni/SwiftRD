namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class SurroundedStringLiteralContent(string valueOfContents, string value) : StringLiteralContent(valueOfContents, value, SwiftTokens.SurroundedStringLiteralContentIndex)
{
    
}