using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleClosingAngleBracketEqualsSignToken : PunctuatorToken<DoubleClosingAngleBracketEqualsSign>
{
    internal DoubleClosingAngleBracketEqualsSignToken()
        : base(ObjectiveCTokens.DoubleClosingAngleBracketEqualsSignId, ObjectiveCTokens.DoubleClosingAngleBracketEqualsSignIndex)
    { }
}