using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class DidSetKeywordToken : ContextSensitiveKeywordToken<DidSet>
{
    internal DidSetKeywordToken()
        : base(DidSet.Keyword, SwiftTokens.DidSetId, SwiftTokens.DidSetIndex)
    { }
}
