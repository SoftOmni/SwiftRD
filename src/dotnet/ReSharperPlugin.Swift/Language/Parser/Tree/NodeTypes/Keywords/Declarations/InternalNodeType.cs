using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

public class InternalNodeType : DeclarationNodeType
{
    internal InternalNodeType()
        : base(SwiftTokens.InternalId, SwiftTokens.InternalIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Tree.Declarations.DeclarationModifiers.AccessLevelModifiers.Leaves.Internal.Create();
    }
}