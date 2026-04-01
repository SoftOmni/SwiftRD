using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Literals;

public class FloatingPointLiteralNodeType : LiteralNodeType
{
    internal FloatingPointLiteralNodeType()
        : base(SwiftTokens.FloatingPointLiteralId, SwiftTokens.FloatingPointLiteralIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new FloatingPointLiteral(buffer);
    }
}