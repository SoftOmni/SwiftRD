using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleVerticalSlashToken : PunctuatorToken<DoubleVerticalSlash>
{
    internal DoubleVerticalSlashToken()
        : base(ObjectiveCTokens.DoubleVerticalSlashId, ObjectiveCTokens.DoubleVerticalSlashIndex)
    { }
}