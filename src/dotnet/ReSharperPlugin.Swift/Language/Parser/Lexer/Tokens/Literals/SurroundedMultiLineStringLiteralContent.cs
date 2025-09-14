namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;

public class SurroundedMultiLineStringLiteralContent(string valueOfContents, string value, int indentation) : MultiLineStringLiteralContent(valueOfContents, value, indentation, SwiftTokens.MultiLineSurroundedStringLiteralContentIndex)
{
}