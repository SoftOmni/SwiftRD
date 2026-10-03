using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class ClosingSquareBracketTrigraphToken : TrigraphToken<ClosingSquareBracketTrigraph>
{
    internal ClosingSquareBracketTrigraphToken()
        : base(ObjectiveCTokens.ClosingSquareBracketTrigraphId, ObjectiveCTokens.ClosingSquareBracketTrigraphIndex)
    { }

    public override char ReplacementCharacter => ClosingSquareBracketTrigraph.EquivalentCharacter;
}