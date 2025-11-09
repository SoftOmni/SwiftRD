using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

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