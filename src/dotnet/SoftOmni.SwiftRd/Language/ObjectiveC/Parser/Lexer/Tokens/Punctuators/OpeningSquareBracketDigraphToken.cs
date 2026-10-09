using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public sealed class OpeningSquareBracketDigraphToken : PunctuatorToken<OpeningSquareBracketDigraph>
{
    internal OpeningSquareBracketDigraphToken()
        : base(ObjectiveCTokens.OpeningSquareBracketDigraphId, ObjectiveCTokens.OpeningSquareBracketDigraphIndex)
    { }
}