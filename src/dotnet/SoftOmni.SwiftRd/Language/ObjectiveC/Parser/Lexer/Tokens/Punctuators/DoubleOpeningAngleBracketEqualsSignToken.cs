using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class DoubleOpeningAngleBracketEqualsSignToken : PunctuatorToken<DoubleOpeningAngleBracketEqualsSign>
{
    internal DoubleOpeningAngleBracketEqualsSignToken()
        : base(ObjectiveCTokens.DoubleOpeningAngleBracketEqualsSignId, ObjectiveCTokens.DoubleOpeningAngleBracketEqualsSignIndex)
    { }
}