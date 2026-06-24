namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PackageKeywordToken : ContextSensitiveKeywordToken
{
    public PackageKeywordToken()
        : base("package", SwiftTokens.PackageId, SwiftTokens.PackageIndex)
    { }
}