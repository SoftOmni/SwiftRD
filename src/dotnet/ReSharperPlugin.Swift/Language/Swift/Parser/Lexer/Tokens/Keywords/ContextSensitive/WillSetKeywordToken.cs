using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;

public class WillSetKeywordToken : ContextSensitiveKeywordToken<WillSet>
{
    internal WillSetKeywordToken()
        : base(WillSet.Keyword, SwiftTokens.WillSetId, SwiftTokens.WillSetIndex)
    { }
}
