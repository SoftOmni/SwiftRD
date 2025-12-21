using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

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