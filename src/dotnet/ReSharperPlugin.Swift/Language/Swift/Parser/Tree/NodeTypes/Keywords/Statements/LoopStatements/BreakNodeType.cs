using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Statements.LoopStatements;

public class BreakNodeType : KeywordNodeType
{
    internal BreakNodeType() 
        : base(SwiftTokens.BreakId, SwiftTokens.BreakIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Break.Create();
    }
}