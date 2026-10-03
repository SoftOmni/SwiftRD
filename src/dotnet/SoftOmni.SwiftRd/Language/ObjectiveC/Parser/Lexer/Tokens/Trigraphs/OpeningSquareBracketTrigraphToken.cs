using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class OpeningSquareBracketTrigraphToken : TrigraphToken<OpeningSquareBracketTrigraph>
{
    internal OpeningSquareBracketTrigraphToken()
        : base(ObjectiveCTokens.OpeningSquareBracketTrigraphId, ObjectiveCTokens.OpeningSquareBracketTrigraphIndex)
    { }

    public override char ReplacementCharacter => OpeningSquareBracketTrigraph.EquivalentCharacter;
}
