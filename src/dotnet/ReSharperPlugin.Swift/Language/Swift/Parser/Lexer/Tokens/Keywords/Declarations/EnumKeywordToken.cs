using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class EnumKeywordToken : DeclarationUsableKeywordToken<Enum>
{
    internal EnumKeywordToken()
        : base(Enum.Keyword, SwiftTokens.EnumId, SwiftTokens.EnumIndex)
    { }
}
