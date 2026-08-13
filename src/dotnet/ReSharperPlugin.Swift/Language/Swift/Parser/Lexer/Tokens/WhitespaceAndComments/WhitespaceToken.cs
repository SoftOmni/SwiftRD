using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class WhitespaceToken() : SwiftTokenNodeType(SwiftTokens.WhitespaceId, SwiftTokens.WhitespaceIndex)
{
    public override string TokenRepresentation { get; } = SwiftTokens.WhitespaceId;

    public override bool IsWhitespace => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
