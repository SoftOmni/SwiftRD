using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Protocols;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

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