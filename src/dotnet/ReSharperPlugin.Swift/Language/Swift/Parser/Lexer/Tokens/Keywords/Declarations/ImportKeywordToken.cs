using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class ImportKeywordToken : DeclarationUsableKeywordToken<Import>
{
    internal ImportKeywordToken()
        : base(Import.Keyword, SwiftTokens.ImportId, SwiftTokens.ImportIndex)
    { }
}
