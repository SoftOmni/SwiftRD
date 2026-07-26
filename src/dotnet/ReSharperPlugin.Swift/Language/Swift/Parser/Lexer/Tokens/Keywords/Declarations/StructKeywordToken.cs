using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;

public class StructKeywordToken : DeclarationUsableKeywordToken<Struct>
{
    public StructKeywordToken()
        : base(Struct.Keyword, SwiftTokens.StructId, SwiftTokens.StructIndex)
    { }
}
