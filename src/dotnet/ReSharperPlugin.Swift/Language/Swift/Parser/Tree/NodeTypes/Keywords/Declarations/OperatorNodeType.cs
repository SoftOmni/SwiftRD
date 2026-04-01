using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.Declarations;

public class OperatorNodeType : DeclarationNodeType
{
    internal OperatorNodeType()
        : base(SwiftTokens.OperatorId, SwiftTokens.OperatorIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return OperatorKeyword.Create();
    }
}