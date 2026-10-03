using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class HashTrigraphToken : TrigraphToken<HashTrigraph>
{
    internal HashTrigraphToken()
        : base(ObjectiveCTokens.HashTrigraphId, ObjectiveCTokens.HashTrigraphIndex)
    { }

    public override char ReplacementCharacter => HashTrigraph.EquivalentCharacter;
}
