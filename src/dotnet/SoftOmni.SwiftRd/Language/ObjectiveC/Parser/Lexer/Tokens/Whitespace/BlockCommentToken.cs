using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Whitespace;

public sealed class BlockCommentToken : ObjectiveCTokenNodeType
{
    internal BlockCommentToken()
        : base(ObjectiveCTokens.BlockCommentId, ObjectiveCTokens.BlockCommentIndex)
    { }

    public override string TokenRepresentation => ObjectiveCTokens.BlockCommentId;

    public override bool IsComment => true;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}
