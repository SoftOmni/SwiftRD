using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningAngleBracketEqualsSignToken : PunctuatorToken<OpeningAngleBracketEqualsSign>
{
    internal OpeningAngleBracketEqualsSignToken()
        : base(ObjectiveCTokens.OpeningAngleBracketEqualsSignId, ObjectiveCTokens.OpeningAngleBracketEqualsSignIndex)
    { }
}
