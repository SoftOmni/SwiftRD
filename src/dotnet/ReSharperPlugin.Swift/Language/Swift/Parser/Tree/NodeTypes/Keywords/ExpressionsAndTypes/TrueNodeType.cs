using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Keywords.ExpressionsAndTypes;

public class TrueNodeType : ExpressionNodeType
{
    internal TrueNodeType()
        : base(SwiftTokens.TrueId, SwiftTokens.TrueIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TrueBackingLiteralToken.Keyword, buffer, SwiftTokens.TrueId);
        return new TrueBooleanLiteral();
    }
}