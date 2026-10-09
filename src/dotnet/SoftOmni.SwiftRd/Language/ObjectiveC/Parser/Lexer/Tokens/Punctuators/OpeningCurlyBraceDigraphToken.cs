using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningCurlyBraceDigraphToken : PunctuatorToken<OpeningCurlyBraceDigraph>
{
    internal OpeningCurlyBraceDigraphToken()
        : base(ObjectiveCTokens.OpeningCurlyBraceDigraphId, ObjectiveCTokens.OpeningCurlyBraceDigraphIndex)
    { }
}