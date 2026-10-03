using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class BackslashTrigraphToken : TrigraphToken<BackslashTrigraph>
{
    internal BackslashTrigraphToken()
        : base(ObjectiveCTokens.BackslashTrigraphId, ObjectiveCTokens.BackslashTrigraphIndex)
    { }

    public override char ReplacementCharacter => BackslashTrigraph.EquivalentCharacter;
}