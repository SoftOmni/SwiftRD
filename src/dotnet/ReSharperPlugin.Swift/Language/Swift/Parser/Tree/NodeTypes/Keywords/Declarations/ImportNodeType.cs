using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Imports;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class ImportNodeType : DeclarationNodeType
{
    internal ImportNodeType()
        : base(SwiftTokens.ImportId, SwiftTokens.ImportIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Import.Create();
    }
}