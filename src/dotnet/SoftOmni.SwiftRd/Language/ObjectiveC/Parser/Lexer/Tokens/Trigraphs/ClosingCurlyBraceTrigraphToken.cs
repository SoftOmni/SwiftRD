using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class ClosingCurlyBraceTrigraphToken : TrigraphToken<ClosingCurlyBraceTrigraph>
{
    internal ClosingCurlyBraceTrigraphToken()
        : base(ObjectiveCTokens.ClosingCurlyBraceTrigraphId, ObjectiveCTokens.ClosingCurlyBraceTrigraphIndex)
    { }

    public override char ReplacementCharacter => ClosingCurlyBraceTrigraph.EquivalentCharacter;
}
