using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class VerticalSlashToken : PunctuatorToken<VerticalSlash>
{
    internal VerticalSlashToken()
        : base(ObjectiveCTokens.VerticalSlashId, ObjectiveCTokens.VerticalSlashIndex)
    { }
}