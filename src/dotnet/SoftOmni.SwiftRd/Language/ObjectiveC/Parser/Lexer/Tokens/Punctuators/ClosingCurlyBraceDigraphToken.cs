using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingCurlyBraceDigraphToken : PunctuatorToken<ClosingCurlyBraceDigraph>
{
    internal ClosingCurlyBraceDigraphToken()
        : base(ObjectiveCTokens.ClosingCurlyBraceDigraphId, ObjectiveCTokens.ClosingCurlyBraceDigraphIndex)
    { }
}