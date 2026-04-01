using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Literals;

public class IntegerLiteralNodeType : LiteralNodeType
{
    internal IntegerLiteralNodeType()
        : base(SwiftTokens.IntegerLiteralId, SwiftTokens.IntegerLiteralIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new IntegerLiteral(buffer);
    }
}