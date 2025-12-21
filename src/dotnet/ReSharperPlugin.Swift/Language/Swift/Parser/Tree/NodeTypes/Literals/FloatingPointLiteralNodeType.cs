using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Literals;

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