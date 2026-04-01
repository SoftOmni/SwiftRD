using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class ProtocolLowercaseNodeType : DeclarationNodeType
{
    internal ProtocolLowercaseNodeType()
        : base(SwiftTokens.ProtocolLowercaseId, SwiftTokens.ProtocolLowercaseIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return ProtocolLowercase.Create();
    }
}