using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;

public abstract class MarkerToken(string tokenId, int index) : SwiftTokenNodeType(string.Empty, index)
{
    public override string TokenRepresentation => tokenId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new NotSupportedException("You cannot create nodes from marker tokens...\n" +
                                        "They are purely there as indications for parser logic " +
                                        "and don't have any AST representation");
    }
}
