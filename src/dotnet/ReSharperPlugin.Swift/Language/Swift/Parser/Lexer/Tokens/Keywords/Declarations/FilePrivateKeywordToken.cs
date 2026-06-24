using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class FilePrivateKeywordToken : DeclarationUsableKeywordToken<FilePrivate>
{
    internal FilePrivateKeywordToken()
        : base(FilePrivate.Keyword, SwiftTokens.FilePrivateId, SwiftTokens.FilePrivateIndex)
    { }
}
