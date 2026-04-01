using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class FuncNodeType : DeclarationNodeType
{
    internal FuncNodeType()
        : base(SwiftTokens.FuncId, SwiftTokens.FuncIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Func.Create();
    }
}