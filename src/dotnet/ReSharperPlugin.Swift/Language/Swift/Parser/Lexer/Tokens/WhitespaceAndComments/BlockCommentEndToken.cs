using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

public class BlockCommentEndToken() : SwiftTokenNodeType(SwiftTokens.BlockCommentEndId, SwiftTokens.BlockCommentEndIndex)
{
    public override string TokenRepresentation => Representation;

    public override bool IsComment => true;

    private const string Representation = "*/";

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
