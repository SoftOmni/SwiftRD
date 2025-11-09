using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Continues;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Statements.LoopStatements;

public class ContinueNodeType : KeywordNodeType
{
    internal ContinueNodeType()
        : base(SwiftTokens.ContinueId, SwiftTokens.ContinueIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Continue.Create();
    }
}