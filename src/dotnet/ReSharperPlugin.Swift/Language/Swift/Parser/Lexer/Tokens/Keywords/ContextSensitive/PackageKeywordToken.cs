using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Keywords;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class PackageKeywordToken : ContextSensitiveKeywordToken<Package>
{
    internal PackageKeywordToken()
        : base(Package.Keyword, SwiftTokens.PackageId, SwiftTokens.PackageIndex)
    { }
}
