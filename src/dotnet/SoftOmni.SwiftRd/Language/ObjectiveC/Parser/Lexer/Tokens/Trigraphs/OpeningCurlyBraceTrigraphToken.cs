using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class OpeningCurlyBraceTrigraphToken : TrigraphToken<OpeningCurlyBraceTrigraph>
{
    internal OpeningCurlyBraceTrigraphToken()
        : base(ObjectiveCTokens.OpeningCurlyBraceTrigraphId, ObjectiveCTokens.OpeningCurlyBraceTrigraphIndex)
    { }

    public override char ReplacementCharacter => OpeningCurlyBraceTrigraph.EquivalentCharacter;
}
