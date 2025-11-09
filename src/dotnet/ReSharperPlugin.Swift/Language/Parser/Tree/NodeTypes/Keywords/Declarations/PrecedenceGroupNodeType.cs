using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

public class PrecedenceGroupNodeType : DeclarationNodeType
{
    internal PrecedenceGroupNodeType()
        : base(SwiftTokens.PrecedenceGroupId, SwiftTokens.PrecedenceGroupIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return PrecedenceGroupKeyword.Create();
    }
}