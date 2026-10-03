using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Trigraphs;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Trigraphs;

public class CaretTrigraphToken : TrigraphToken<CaretTrigraph>
{
    internal CaretTrigraphToken()
        : base(ObjectiveCTokens.CaretTrigraphId, ObjectiveCTokens.CaretTrigraphIndex)
    { }

    public override char ReplacementCharacter => CaretTrigraph.EquivalentCharacter;
}