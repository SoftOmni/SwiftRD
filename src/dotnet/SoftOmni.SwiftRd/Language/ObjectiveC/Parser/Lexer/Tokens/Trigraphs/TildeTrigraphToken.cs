using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class TildeTrigraphToken : TrigraphToken<TildeTrigraph>
{
    internal TildeTrigraphToken()
        : base(ObjectiveCTokens.TildeTrigraphId, ObjectiveCTokens.TildeTrigraphIndex)
    { }

    public override char ReplacementCharacter => TildeTrigraph.EquivalentCharacter;
}