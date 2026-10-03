using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class VerticalSlashEqualsSignToken : PunctuatorToken<VerticalSlashEqualsSign>
{
    internal VerticalSlashEqualsSignToken()
        : base(ObjectiveCTokens.VerticalSlashEqualsSignId, ObjectiveCTokens.VerticalSlashEqualsSignIndex)
    { }
}