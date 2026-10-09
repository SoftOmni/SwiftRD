using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class ClosingSquareBracketDigraphToken : PunctuatorToken<ClosingSquareBracketDigraph>
{
    internal ClosingSquareBracketDigraphToken()
        : base(ObjectiveCTokens.ClosingSquareBracketDigraphId, ObjectiveCTokens.ClosingSquareBracketDigraphIndex)
    { }
}