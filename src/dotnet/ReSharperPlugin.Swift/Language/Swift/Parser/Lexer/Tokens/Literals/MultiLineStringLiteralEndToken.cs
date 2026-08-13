using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralEndToken : StringLiteralBoundaryToken
{
    public MultiLineStringLiteralEndToken()
    : this(SwiftTokens.MultiLineStringLiteralEndId,
        SwiftTokens.MultiLineStringLiteralEndIndex)
    { }
    
    protected MultiLineStringLiteralEndToken(string tokenId, int index)
        : base(tokenId, index)
    { }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}