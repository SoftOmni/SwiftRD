using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Whitespace;

public sealed class WhitespaceToken : ObjectiveCTokenNodeType
{
    internal WhitespaceToken()
        : base(ObjectiveCTokens.WhitespaceId, ObjectiveCTokens.WhitespaceIndex)
    { }

    public override string TokenRepresentation => ObjectiveCTokens.WhitespaceId;

    public override bool IsWhitespace => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
