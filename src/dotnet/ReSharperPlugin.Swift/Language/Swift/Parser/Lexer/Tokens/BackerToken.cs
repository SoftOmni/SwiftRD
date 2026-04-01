namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;

public abstract class BackerToken(string value, int index)
{
    public string Value { get; } = value;

    public int Index { get; } = index;
}