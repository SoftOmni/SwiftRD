namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Markers;

public sealed class StartOfFileToken : MarkerToken
{
    internal StartOfFileToken()
        : base(ObjectiveCTokens.StartOfFileId, ObjectiveCTokens.StartOfFileIndex)
    { }
}
