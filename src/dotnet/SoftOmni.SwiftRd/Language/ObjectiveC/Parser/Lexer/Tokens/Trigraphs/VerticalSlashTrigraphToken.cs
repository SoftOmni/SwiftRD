using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class VerticalSlashTrigraphToken : TrigraphToken<VerticalSlashTrigraph>
{
    internal VerticalSlashTrigraphToken()
        : base(ObjectiveCTokens.VerticalSlashTrigraphId, ObjectiveCTokens.VerticalSlashTrigraphIndex)
    { }

    public override char ReplacementCharacter => VerticalSlashTrigraph.EquivalentCharacter;
}
