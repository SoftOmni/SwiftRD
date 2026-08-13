using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class MultiLineStringLiteralStartToken : StringLiteralBoundaryToken
{
    public MultiLineStringLiteralStartToken() : this(SwiftTokens.MultiLineStringLiteralStartId, SwiftTokens.MultiLineStringLiteralStartIndex)
    { }
    
    protected MultiLineStringLiteralStartToken(string tokenId, int index)
        : base(tokenId, index)
    { }

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}