namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Markers;

public sealed class EmptyToken : MarkerToken
{
    internal EmptyToken()
        : base(ObjectiveCTokens.EmptyId, ObjectiveCTokens.EmptyTokenIndex)
    { }
}
