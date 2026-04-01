using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements.Continues;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Statements.LoopStatements;

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