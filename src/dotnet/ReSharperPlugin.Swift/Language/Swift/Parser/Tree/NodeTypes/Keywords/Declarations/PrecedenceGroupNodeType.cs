using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

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