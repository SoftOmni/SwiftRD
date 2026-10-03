namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Markers;

public sealed class EndOfFileToken : MarkerToken
{
    internal EndOfFileToken()
        : base(ObjectiveCTokens.EndOfFileId, ObjectiveCTokens.EndOfFileIndex)
    { }
}
